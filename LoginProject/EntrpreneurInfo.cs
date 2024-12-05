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
    public partial class EntrpreneurInfo : Form
    {
        public EntrpreneurInfo()
        {
            InitializeComponent();
        }

      

        private void EntrpreneurInfo_Load(object sender, EventArgs e)
        {
            

        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            Helper.SmoothTransition(this, signup);
        }

        private void EntrpreneurInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signupasdesigner_Click(object sender, EventArgs e)
        {
            AllProducts allProducts = new AllProducts(); 
            Helper.SmoothTransition(this,allProducts);


        }
    }
}
