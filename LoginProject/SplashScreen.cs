using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginProject
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        

       
        private void button1_Click(object sender, EventArgs e)
        {
           AllProducts allProducts = new AllProducts();
            this.Hide();
            allProducts.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AllProducts allProducts = new AllProducts();
            this.Hide();
            allProducts.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void login_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.Show();
        }

        private void gohomepagewithoulogin_Click(object sender, EventArgs e)
        {
           
            var dialog = MessageBox.Show("Please login or sign up", "Warning", MessageBoxButtons.OKCancel, icon: MessageBoxIcon.Stop);

            if (dialog == DialogResult.OK)
            {
                Login login= new Login();
                Helper.SmoothTransition(this, login);
            }
           

            //AllProducts allProducts=new AllProducts();
            //this.Hide();
            //allProducts.Show();
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void gohomepagewithoulogin_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(gohomepagewithoulogin, "ShopSphere is here!!! Let's try together");
        }

        private void login_btn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(login_btn, "Login Please");
        }
        
       
        private void signup_btn_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(signup_btn, "Welcome signup Please");
        }
    }
}
