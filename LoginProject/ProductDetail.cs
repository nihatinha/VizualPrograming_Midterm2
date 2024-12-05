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
    public partial class ProductDetail : Form
    {

        public ProductDetail()
        {
            InitializeComponent();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            Helper.SmoothTransition(this,splashScreen);
        }

        private void viewAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllProducts allProducts = new AllProducts();
            Helper.SmoothTransition(this,allProducts); 
        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            var dialog=MessageBox.Show("Product added succesfully","Success",MessageBoxButtons.OK);
        }
    }
}
