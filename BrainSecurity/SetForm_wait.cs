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
    public partial class SetForm_wait : Form
    {
        public SetForm_wait()
        {
            InitializeComponent();
        }
        
        public void Finish()
        {
            this.Hide();
            SetForm_fin finForm = new SetForm_fin();
            finForm.Show();
        }
    }
}
