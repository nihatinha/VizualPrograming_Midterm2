using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginProject
{
    public static class Helper
    {
        public static void SmoothTransition(Form currentForm, Form nextForm)
        {
            //Timer timer = new Timer();
            //timer.Interval = 1; 
            //timer.Tick += (s, e) =>
            //{
            //    if (currentForm.Opacity > 0)
            //    {
            //        currentForm.Opacity -= 0.5; 
            //    }
            //    else
            //    {
            //        timer.Stop();
            //        nextForm.Show(); 
            //        currentForm.Hide(); 
            //        currentForm.Opacity = 1; 
            //    }
            //};

            //timer.Start();
            nextForm.Show();
            currentForm.Hide();

        }

        public static void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray; 
            }

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = string.Empty; 
                    textBox.ForeColor = Color.Black; 
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

    }
}
