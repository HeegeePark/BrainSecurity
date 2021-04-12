using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;


namespace BrainSecurity
{
    class Data_Analyzer
    {
        // 몇번째 반복인지 알아야함
        // EEG 데이터를 저장해야함
        // Reference 데이터를 저장해야함
        ArrayList dataList;
        ArrayList refList;
        ArrayList eegList;
        double[] totalData_A = new double[128];
        double[] totalData_B = new double[128];
        int ref_Cnt = 0;
        int trash_Cnt = 0;
        int eeg_Cnt = 0;
        int sampling_rate = 128; // Hz
        int count = 12;

        public Data_Analyzer()
        {
            refList = new ArrayList();
            eegList = new ArrayList();
            dataList = new ArrayList();
            for (int i = 0; i < 128; i++)
            {
                totalData_A[i] = 0;
                totalData_B[i] = 0;
            }
        }
        ///////////
        public void AddData(double data)
        {
            dataList.Add(data);
        }

        public double[] Analysis()
        {
            try
            {
                //데이터 저장
                //double[] data = ReadData("data.txt");
                for (int j = 0; j < count; j++)
                {
                    // 1. Split data into reference and eeg
                    for (int i = 0; i < 192; i++)
                    {
                        if (i > 38 && i < 64) // 0.7s~ 1s reference
                        {
                            refList.Add(dataList[i + j * (192)]);
                            ref_Cnt += 1;
                        }
                        // refList[i] = data;
                        else if (i >= 64)
                        {
                            eegList.Add(dataList[i + j * (192)]);
                            eeg_Cnt += 1;
                        }

                        else
                            trash_Cnt += 1;
                        continue;
                    }
                    // 2. Bandpass filter (5~30Hz)
                    //double[] bandRefData = BandPass((Double[])refList.ToArray(typeof(Double)), sampling_rate, 5, 30, 10000000);
                    //double[] bandData = BandPass((Double[])eegList.ToArray(typeof(Double)), sampling_rate, 5, 30, 10000000);
                    double[] bandRefData = (Double[])refList.ToArray(typeof(Double));
                    double[] bandData = (Double[])eegList.ToArray(typeof(Double));

                    // 3. Calculate average of reference
                    double reference = CalculateReference(bandRefData);

                    // 4. Normalize data based on reference
                    double[] normData = Normalization(bandData, reference);

                    // 5. Add data
                    for (int i = 0; i < 128; i++)
                    {
                        //A
                        if (j % 2 == 0)
                            totalData_A[i] += normData[i];
                        //B
                        else if (j % 2 == 1)
                            totalData_B[i] += normData[i];

                    }

                    // 6. Clear lists
                    ClearSplit();
                }

                //데이터 분석
                // 1. Average data
                for (int i = 0; i < 128; i++)
                {
                    totalData_A[i] /= 6;
                    totalData_B[i] /= 6;
                }


                // 2. Detect ERP
                double erp_A = DetectERP(totalData_A);
                double erp_B = DetectERP(totalData_B);

                double[] erp = { erp_A, erp_B };

                // 3. Clear data
                ClearData();

                return erp;
            }
            catch (Exception e)
            {
                double[] erp_except = { 0, 0 };
                return erp_except;
            }
        }

        public void ClearData()
        {
            dataList.Clear();
        }

        public void ClearSplit()
        {
            refList.Clear();
            eegList.Clear();
        }

        [DllImport("coclib", CallingConvention = CallingConvention.Cdecl)]
        extern public static IntPtr band_pass_filter(double[] data, int length, int sampling_rate, double low_cut, double high_cut, int mag_alpha);

        public static double[] BandPass(double[] data, int sampling_rate, double low_cut, double high_cut, int mag_alpha)
        {
            IntPtr bandPointer = band_pass_filter(data, data.Length, sampling_rate, low_cut, high_cut, mag_alpha);
            int[] bandData = new int[data.Length];
            double[] outData = new double[data.Length];
            Marshal.Copy(bandPointer, bandData, 0, data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                outData[i] = bandData[i] / (double)mag_alpha;
            }
            return outData;
        }

        public static double CalculateReference(double[] reference)
        {
            double sum = 0;
            for (int i = 0; i < reference.Length; i++)
            {
                sum += reference[i];
            }
            double avg = sum / reference.Length;
            return avg;
        }

        private static double[] Normalization(double[] data, double reference)
        {
            double[] normData = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                normData[i] = data[i] - reference;
            }
            return normData;
        }

        private static double DetectERP(double[] data)
        {
            double max = 0;
            for (int i = 0; i < data.Length; i++)
            {
                double power = Math.Abs(data[i]);
                if (power >= max)
                {
                    max = power;
                }
            }
            return max;
        }
    }
}
