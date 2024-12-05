namespace LoginProject
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginlabel = new System.Windows.Forms.Label();
            this.emailaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gosignuppage = new System.Windows.Forms.Label();
            this.log_btn = new System.Windows.Forms.Button();
            this.pswdtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.unamelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.loginlabel.Location = new System.Drawing.Point(142, 98);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(99, 35);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Login";
            // 
            // emailaddress
            // 
            this.emailaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.emailaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailaddress.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.emailaddress.Location = new System.Drawing.Point(46, 213);
            this.emailaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailaddress.Multiline = true;
            this.emailaddress.Name = "emailaddress";
            this.emailaddress.Size = new System.Drawing.Size(295, 33);
            this.emailaddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Don\'t you have an account?";
            // 
            // gosignuppage
            // 
            this.gosignuppage.AutoSize = true;
            this.gosignuppage.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gosignuppage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.gosignuppage.Location = new System.Drawing.Point(247, 420);
            this.gosignuppage.Name = "gosignuppage";
            this.gosignuppage.Size = new System.Drawing.Size(52, 18);
            this.gosignuppage.TabIndex = 6;
            this.gosignuppage.Text = "Sign up";
            this.gosignuppage.Click += new System.EventHandler(this.gosignuppage_Click);
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.ForeColor = System.Drawing.Color.White;
            this.log_btn.Location = new System.Drawing.Point(46, 459);
            this.log_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(295, 46);
            this.log_btn.TabIndex = 7;
            this.log_btn.Text = "Login";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // pswdtext
            // 
            this.pswdtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.pswdtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pswdtext.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.pswdtext.Location = new System.Drawing.Point(46, 290);
            this.pswdtext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pswdtext.Multiline = true;
            this.pswdtext.Name = "pswdtext";
            this.pswdtext.PasswordChar = '*';
            this.pswdtext.Size = new System.Drawing.Size(295, 33);
            this.pswdtext.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.label3.Location = new System.Drawing.Point(42, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pswdtext);
            this.panel1.Controls.Add(this.loginlabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.unamelabel);
            this.panel1.Controls.Add(this.log_btn);
            this.panel1.Controls.Add(this.gosignuppage);
            this.panel1.Controls.Add(this.emailaddress);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(89, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 528);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Welcome back!!!";
            // 
            // unamelabel
            // 
            this.unamelabel.AutoSize = true;
            this.unamelabel.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.unamelabel.ForeColor = System.Drawing.Color.Black;
            this.unamelabel.Location = new System.Drawing.Point(42, 185);
            this.unamelabel.Name = "unamelabel";
            this.unamelabel.Size = new System.Drawing.Size(50, 23);
            this.unamelabel.TabIndex = 1;
            this.unamelabel.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(744, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 711);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.label5.Location = new System.Drawing.Point(164, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "ShopSphere";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(571, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(93, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 526);
            this.panel4.TabIndex = 14;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(11, 28);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 27);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 705);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.TextBox emailaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gosignuppage;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.TextBox pswdtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label unamelabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox11;
    }
}

