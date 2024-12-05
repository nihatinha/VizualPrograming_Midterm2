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
    public partial class AllProducts : Form
    {
        public AllProducts()
        {
            InitializeComponent();
        }

        

     
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            SplashScreen splashscreen = new SplashScreen();
            Helper.SmoothTransition(this, splashscreen);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AllProducts_Load(object sender, EventArgs e)
        {

        }

        private void searching_TextChanged(object sender, EventArgs e)
        {
            Helper.SetPlaceholder(searching,"Search...");
        }

        private void AllProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void viewAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void goowndesign_btn_Click(object sender, EventArgs e)
        {
            DesignYourself designYourself = new DesignYourself();
            Helper.SmoothTransition(this, designYourself);
        }

        private void details_Click(object sender, EventArgs e)
        {
           
            ProductDetail detail = new ProductDetail();
            Helper.SmoothTransition(this, detail);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            Helper.SmoothTransition(this, splashScreen);
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            Helper.SmoothTransition(this, orders);
        }
    }
}
