using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class DesignYourself : Form
    {
        public DesignYourself()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void whitebtn_Click(object sender, EventArgs e)
        {
            pictureBoxTshirt.Visible = true;
            blackshirt.Visible = false;
            modelpic.Visible = false;
        }

        private void blackbtn_Click(object sender, EventArgs e)
        {
            pictureBoxTshirt.Visible = false;
            blackshirt.Visible = true;
            modelpic.Visible = false;

        }

        private void seemodel_Click(object sender, EventArgs e)
        {
            modelpic.Visible = true;
            pictureBoxTshirt.Visible = false;
            blackshirt.Visible = false;
        }

        private void addtocartbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The product add to cart hurry to buy it","Success",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            Payment payment = new Payment();
            Helper.SmoothTransition(this, payment);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AllProducts allProducts = new AllProducts();
            Helper.SmoothTransition(this,allProducts);
        }

        private void uploadimagebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                byte[] imageBytes = File.ReadAllBytes(selectedFile);


                MessageBox.Show("Picture added successfully");
            }
        }

        private void viewAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllProducts allProducts= new AllProducts();
            Helper.SmoothTransition(this,allProducts);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            Helper.SmoothTransition(this,splashScreen);
        }
    }


        
}

