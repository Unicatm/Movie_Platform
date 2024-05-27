namespace Proiect
{
    partial class LogIn
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LkLblLogIn = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CPassword = new Proiect.InputField();
            this.CkBViewPassword = new System.Windows.Forms.CheckBox();
            this.CEmail = new Proiect.InputField();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.LnkToHomepage = new System.Windows.Forms.LinkLabel();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.LnkToHomepage);
            this.panel6.Location = new System.Drawing.Point(786, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 900);
            this.panel6.TabIndex = 28;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.CEmail);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.BtnSignUp);
            this.panel3.Location = new System.Drawing.Point(59, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 523);
            this.panel3.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.LkLblLogIn);
            this.panel2.Location = new System.Drawing.Point(109, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 27);
            this.panel2.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "You don\'t have an account?";
            // 
            // LkLblLogIn
            // 
            this.LkLblLogIn.AutoSize = true;
            this.LkLblLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LkLblLogIn.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblLogIn.LinkColor = System.Drawing.Color.MidnightBlue;
            this.LkLblLogIn.Location = new System.Drawing.Point(197, 4);
            this.LkLblLogIn.Name = "LkLblLogIn";
            this.LkLblLogIn.Size = new System.Drawing.Size(52, 23);
            this.LkLblLogIn.TabIndex = 26;
            this.LkLblLogIn.TabStop = true;
            this.LkLblLogIn.Text = "Sign In";
            this.LkLblLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblLogIn_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.CPassword);
            this.panel1.Controls.Add(this.CkBViewPassword);
            this.panel1.Location = new System.Drawing.Point(18, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 111);
            this.panel1.TabIndex = 33;
            // 
            // CPassword
            // 
            this.CPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPassword.BackColor = System.Drawing.Color.Transparent;
            this.CPassword.Location = new System.Drawing.Point(0, 3);
            this.CPassword.Name = "CPassword";
            this.CPassword.PasswordCharType = '*';
            this.CPassword.Size = new System.Drawing.Size(450, 82);
            this.CPassword.TabIndex = 32;
            this.CPassword.Title = "Password";
            // 
            // CkBViewPassword
            // 
            this.CkBViewPassword.AutoSize = true;
            this.CkBViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CkBViewPassword.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBViewPassword.Location = new System.Drawing.Point(0, 81);
            this.CkBViewPassword.Name = "CkBViewPassword";
            this.CkBViewPassword.Size = new System.Drawing.Size(134, 27);
            this.CkBViewPassword.TabIndex = 20;
            this.CkBViewPassword.Text = "Show Password";
            this.CkBViewPassword.UseVisualStyleBackColor = true;
            this.CkBViewPassword.CheckedChanged += new System.EventHandler(this.CkBViewPassword_CheckedChanged);
            // 
            // CEmail
            // 
            this.CEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CEmail.BackColor = System.Drawing.Color.Transparent;
            this.CEmail.Location = new System.Drawing.Point(18, 150);
            this.CEmail.Name = "CEmail";
            this.CEmail.PasswordCharType = '\0';
            this.CEmail.Size = new System.Drawing.Size(450, 82);
            this.CEmail.TabIndex = 29;
            this.CEmail.Title = "Email";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(169, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log In";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSignUp.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSignUp.Location = new System.Drawing.Point(18, 366);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(450, 48);
            this.BtnSignUp.TabIndex = 18;
            this.BtnSignUp.Text = "Log In";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // LnkToHomepage
            // 
            this.LnkToHomepage.AutoSize = true;
            this.LnkToHomepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkToHomepage.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkToHomepage.LinkColor = System.Drawing.Color.MidnightBlue;
            this.LnkToHomepage.Location = new System.Drawing.Point(16, 16);
            this.LnkToHomepage.Name = "LnkToHomepage";
            this.LnkToHomepage.Size = new System.Drawing.Size(53, 30);
            this.LnkToHomepage.TabIndex = 19;
            this.LnkToHomepage.TabStop = true;
            this.LnkToHomepage.Text = "Back";
            this.LnkToHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkToHomepage_LinkClicked);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel6);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel LkLblLogIn;
        private System.Windows.Forms.Panel panel1;
        private InputField CPassword;
        private System.Windows.Forms.CheckBox CkBViewPassword;
        private InputField CEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.LinkLabel LnkToHomepage;
    }
}