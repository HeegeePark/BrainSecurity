using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainSecurity
{
    public partial class SlideForm : Form
    {
        int num = 0;
        bool ref_cnt = false;
        int targetNumber = 0;
        Random r = new Random();
        int non_Target;

        public SlideForm()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            

        }

        public void SelectTarget(int target)
        {
            targetNumber = target;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            non_Target = r.Next(0, 9);
            while (non_Target==targetNumber)
            {
                non_Target = r.Next(0, 9);
            }
            if (num>=30)
            {
                timer1.Stop();
                this.Hide();
                SetForm_wait waitForm = new SetForm_wait();
                waitForm.Show();
            }

            if (ref_cnt)
            {
                slide_img.Load("C:\\Users\\user\\Desktop\\인지공학\\BrainSecurity\\NumberImage\\ref.png");
                slide_img.SizeMode = PictureBoxSizeMode.StretchImage;
                ref_cnt = false;
            }

            else if (num%10==1 || num % 10 == 5 || num % 10 == 8)
            {
                //label1.Text = num.ToString();
                slide_img.Load("C:\\Users\\user\\Desktop\\인지공학\\BrainSecurity\\NumberImage\\Target_" + targetNumber + ".png");
                slide_img.SizeMode = PictureBoxSizeMode.StretchImage;
                num++;
                ref_cnt = true;
            }

            else
            {
                //label1.Text = num.ToString();
                slide_img.Load("C:\\Users\\user\\Desktop\\인지공학\\BrainSecurity\\NumberImage\\Non_" + non_Target + ".png");
                slide_img.SizeMode = PictureBoxSizeMode.StretchImage;
                num++;
                ref_cnt = true;
            }
            
        }
    }
}
