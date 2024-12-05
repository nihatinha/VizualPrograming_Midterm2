namespace LoginProject
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signupasdesigner = new System.Windows.Forms.Button();
            this.phonenumlabel = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.fullnametxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.motivationtxt2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(-149, -87);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 27);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 31;
            this.pictureBox11.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.signupasdesigner);
            this.panel1.Controls.Add(this.phonenumlabel);
            this.panel1.Controls.Add(this.phoneTxt);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.fullnametxt);
            this.panel1.Location = new System.Drawing.Point(368, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 408);
            this.panel1.TabIndex = 32;
            // 
            // signupasdesigner
            // 
            this.signupasdesigner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(116)))), ((int)(((byte)(88)))));
            this.signupasdesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupasdesigner.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupasdesigner.ForeColor = System.Drawing.Color.White;
            this.signupasdesigner.Location = new System.Drawing.Point(27, 204);
            this.signupasdesigner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signupasdesigner.Name = "signupasdesigner";
            this.signupasdesigner.Size = new System.Drawing.Size(379, 46);
            this.signupasdesigner.TabIndex = 29;
            this.signupasdesigner.Text = "Confirm";
            this.signupasdesigner.UseVisualStyleBackColor = false;
            this.signupasdesigner.Click += new System.EventHandler(this.signupasdesigner_Click);
            // 
            // phonenumlabel
            // 
            this.phonenumlabel.AutoSize = true;
            this.phonenumlabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumlabel.Location = new System.Drawing.Point(23, 115);
            this.phonenumlabel.Name = "phonenumlabel";
            this.phonenumlabel.Size = new System.Drawing.Size(99, 21);
            this.phonenumlabel.TabIndex = 13;
            this.phonenumlabel.Text = "Date(month)";
            // 
            // phoneTxt
            // 
            this.phoneTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.phoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTxt.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.phoneTxt.Location = new System.Drawing.Point(27, 136);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTxt.Multiline = true;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(52, 33);
            this.phoneTxt.TabIndex = 12;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(23, 59);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(101, 21);
            this.namelabel.TabIndex = 9;
            this.namelabel.Text = "Card number";
            // 
            // fullnametxt
            // 
            this.fullnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.fullnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullnametxt.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.fullnametxt.Location = new System.Drawing.Point(23, 80);
            this.fullnametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullnametxt.Multiline = true;
            this.fullnametxt.Name = "fullnametxt";
            this.fullnametxt.Size = new System.Drawing.Size(383, 33);
            this.fullnametxt.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(368, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 418);
            this.panel3.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // motivationtxt2
            // 
            this.motivationtxt2.BackColor = System.Drawing.Color.Transparent;
            this.motivationtxt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motivationtxt2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.motivationtxt2.ForeColor = System.Drawing.Color.Black;
            this.motivationtxt2.Location = new System.Drawing.Point(506, 104);
            this.motivationtxt2.Name = "motivationtxt2";
            this.motivationtxt2.Size = new System.Drawing.Size(118, 38);
            this.motivationtxt2.TabIndex = 33;
            this.motivationtxt2.Text = "Payment";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.textBox2.Location = new System.Drawing.Point(174, 136);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 33);
            this.textBox2.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Date(day)";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.motivationtxt2);
            this.Controls.Add(this.pictureBox11);
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signupasdesigner;
        private System.Windows.Forms.Label phonenumlabel;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox fullnametxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label motivationtxt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}