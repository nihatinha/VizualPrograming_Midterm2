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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            var iscustomer=customer_btn.Checked;
            var isentrepreneur=entrepreneur_btn.Checked;
            if (iscustomer)
            {
                SplashScreen splashscreen = new SplashScreen();
                Helper.SmoothTransition(this, splashscreen);
                this.Hide();
            }
            else
            {
                EntrpreneurInfo entrpreneur_info = new EntrpreneurInfo();
                Helper.SmoothTransition(this, entrpreneur_info);
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SplashScreen splashscreen = new SplashScreen();
            Helper.SmoothTransition(this, splashscreen);
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
