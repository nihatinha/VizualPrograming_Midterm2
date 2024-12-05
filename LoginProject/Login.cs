using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn", SetLastError = true)]
        private static extern IntPtr CreateRoundRectRgn(int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
        
        
        public Login()
        {
            InitializeComponent();
        }

        public List<User> users = new List<User>() 
        {
        new User(){Email="nurlanhsnv@gmail.com",Username="Nurlan",Password="2207"},
        new User(){Email="nqarayev5@std.beu.edu.az",Username="Nihat",Password="2109"},
        new User(){Email = "elmirshidev1@gmail.com", Username="Elmir",Password="2304"}
        };
        

        private void log_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var mail = emailaddress.Text.Trim();
                var pswd = pswdtext.Text.Trim();
                bool loginsuccesfull = false;
                foreach (var user in users)
                {
                    if ( user.Password == pswd && user.Email==mail)
                    {
                        MessageBox.Show("Login succesfully!!");
                        loginsuccesfull = true;
                        AllProducts allProducts = new AllProducts();
                        Helper.SmoothTransition(this, allProducts);

                    }

                }
                if (loginsuccesfull == false)
                {
                    MessageBox.Show("Please enter the valid username or password","Something went wrong");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login. Please try again.","Warning!"); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            log_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, log_btn.Width, log_btn.Height, 15, 15));
        }

       

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SplashScreen splashscreen = new SplashScreen();
            Helper.SmoothTransition(this, splashscreen);
        }

        private void gosignuppage_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
           Helper.SmoothTransition(this, signup);

        }

       

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
