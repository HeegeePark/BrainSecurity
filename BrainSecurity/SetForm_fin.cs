using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emotiv;

namespace BrainSecurity
{
    public partial class SetForm_fin : Form
    {
        public SetForm_fin()
        {
            InitializeComponent();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CertifYForm_select selForm = new CertifYForm_select();
            selForm.Show();
        }
    }
}
