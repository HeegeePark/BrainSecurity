using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BrainSecurity
{
    public partial class SetForm : Form
    {
        bool[] target_flags = { false, false, false, false, false, false, false, false, false, false};
        int target = 10;

        public SetForm()
        {
            InitializeComponent();
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            String ID = this.IDbox.Text;
            string filename = "C:\\Users\\user\\Desktop\\인지공학\\BrainSecurity\\User_base#\\User_" + ID + ".txt"; // output filename        
            //Program.logger.Start(filename);
            for (int i = 0; i < target_flags.Length; i++)
            {
                if(target_flags[i])
                    target = i;
            }

            if (IDbox.Text == "" || target == 10)
            {
                SetForm_warning warning = new SetForm_warning();
                warning.Show();
            }

            else
            {
                Program.slideForm = new SlideForm();
                Program.slideForm.SelectTarget(target);
                this.Hide();
                SetForm_explain expform = new SetForm_explain();
                expform.Show();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            button_click_event(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_click_event(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_click_event(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_click_event(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_click_event(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_click_event(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_click_event(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_click_event(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_click_event(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_click_event(9);
        }

        private void button_click_event(int index)
        {
            Button[] buttons = { button0, button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            for (int i = 0; i < target_flags.Length; i++)
            {
                if (i == index)
                {
                    target_flags[i] = true;
                    buttons[i].BackColor = Color.Cyan;
                }
                else
                {
                    target_flags[i] = false;
                    buttons[i].BackColor = Color.White;
                }
            }
        }
    }
}
