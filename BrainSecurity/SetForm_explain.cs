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
    public partial class SetForm_explain : Form
    {
        public SetForm_explain()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //SlideForm slideform = new SlideForm();
            Program.slideForm.Show();
            
        }
    }
}
