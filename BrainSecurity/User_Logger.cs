using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Emotiv;
using System.IO;

namespace BrainSecurity
{
    class User_Logger
    { 
        EmoEngine engine;   // Access to the EDK is via the EmoEngine 
        int userID = -1;    // userID is used to uniquely identify a user's headset

        Data_Analyzer f7_analyzer;
        string filename;

        public User_Logger()
        {
            // create the engine
            engine = EmoEngine.Instance;
            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);

            // connect to Emoengine.            
            engine.Connect();

            // create a analyzer for f7 channel
            f7_analyzer = new Data_Analyzer();


        }

        void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("User Added Event has occured");

            // record the user 
            userID = (int)e.userId;

            // enable data aquisition for this user.
            engine.DataAcquisitionEnable((uint)userID, true);

            // ask for up to 1 second of buffered data
            engine.DataSetBufferSizeInSec(1);

        }


        public void Run()
        {
            // Handle any waiting events
            engine.ProcessEvents();

            // If the user has not yet connected, do not proceed
            if ((int)userID == -1)
                return;

            Dictionary<EdkDll.IEE_DataChannel_t, double[]> data = engine.GetData((uint)userID);

            if (data == null)
            {
                return;
            }

            int _bufferSize = data[EdkDll.IEE_DataChannel_t.IED_TIMESTAMP].Length;



            for (int i = 0; i < _bufferSize; i++)
            {
                // now analyze the data
                foreach (EdkDll.IEE_DataChannel_t channel in data.Keys)
                {
                    if (Convert.ToString(channel) == "IED_F7")
                    {
                        f7_analyzer.AddData(data[channel][i]);

                    }

                }


            }

            

            
        }

        public void WriteData()
        {
            //// Write the data to a file
            TextWriter file = new StreamWriter(filename, true);

            //for (int i = 0; i < _bufferSize; i++)
            //{
            //    // now write the data
            //    foreach (EdkDll.IEE_DataChannel_t channel in data.Keys)
            //        file.Write(data[channel][i] + ",");
            //    file.WriteLine("");

            //}

            file.Close();
        }

        public void Start(String filename)
        {
            while (true)
            {
                if (Console.KeyAvailable)
                    break;
                //Example for set marker to data stream and set sychronization signal
                //if (i % 37 == 0)
                //{
                //    p.engine.DataSetMarker((uint)p.userID, i);
                //    p.engine.DataSetSychronizationSignal((uint)p.userID, i);
                //}
                Program.logger.Run();
                Thread.Sleep(10);
            }

            Console.WriteLine("Start");
        }

        public void Stop(String filename)
        {
            Console.WriteLine("Stop");
            Program.logger.WriteData();
        }
    }
}
