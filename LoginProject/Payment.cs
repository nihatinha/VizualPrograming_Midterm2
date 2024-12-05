using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void signupasdesigner_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you wanna buy it?","Acceptance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
