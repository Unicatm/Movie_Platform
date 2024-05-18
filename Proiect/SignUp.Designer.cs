namespace Proiect
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.LnkToHomepage = new System.Windows.Forms.LinkLabel();
            this.CkBViewPassword = new System.Windows.Forms.CheckBox();
            this.LkLblLogIn = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputField5 = new Proiect.InputField();
            this.inputField4 = new Proiect.InputField();
            this.inputField3 = new Proiect.InputField();
            this.inputField2 = new Proiect.InputField();
            this.inputField1 = new Proiect.InputField();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(150, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSignUp.Location = new System.Drawing.Point(17, 639);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(450, 48);
            this.BtnSignUp.TabIndex = 18;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            // 
            // LnkToHomepage
            // 
            this.LnkToHomepage.AutoSize = true;
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
            // CkBViewPassword
            // 
            this.CkBViewPassword.AutoSize = true;
            this.CkBViewPassword.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkBViewPassword.Location = new System.Drawing.Point(0, 81);
            this.CkBViewPassword.Name = "CkBViewPassword";
            this.CkBViewPassword.Size = new System.Drawing.Size(134, 27);
            this.CkBViewPassword.TabIndex = 20;
            this.CkBViewPassword.Text = "Show Password";
            this.CkBViewPassword.UseVisualStyleBackColor = true;
            // 
            // LkLblLogIn
            // 
            this.LkLblLogIn.AutoSize = true;
            this.LkLblLogIn.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LkLblLogIn.LinkColor = System.Drawing.Color.MidnightBlue;
            this.LkLblLogIn.Location = new System.Drawing.Point(182, 4);
            this.LkLblLogIn.Name = "LkLblLogIn";
            this.LkLblLogIn.Size = new System.Drawing.Size(47, 23);
            this.LkLblLogIn.TabIndex = 26;
            this.LkLblLogIn.TabStop = true;
            this.LkLblLogIn.Text = "Log In";
            this.LkLblLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LkLblLogIn_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Already have an account?";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.LnkToHomepage);
            this.panel6.Location = new System.Drawing.Point(785, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 900);
            this.panel6.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.inputField4);
            this.panel3.Controls.Add(this.inputField3);
            this.panel3.Controls.Add(this.inputField2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.inputField1);
            this.panel3.Controls.Add(this.BtnSignUp);
            this.panel3.Location = new System.Drawing.Point(49, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 738);
            this.panel3.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.LkLblLogIn);
            this.panel2.Location = new System.Drawing.Point(127, 702);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 27);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.inputField5);
            this.panel1.Controls.Add(this.CkBViewPassword);
            this.panel1.Location = new System.Drawing.Point(17, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 111);
            this.panel1.TabIndex = 33;
            // 
            // inputField5
            // 
            this.inputField5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputField5.BackColor = System.Drawing.Color.Transparent;
            this.inputField5.Location = new System.Drawing.Point(0, 3);
            this.inputField5.Name = "inputField5";
            this.inputField5.PasswordCharType = '*';
            this.inputField5.Size = new System.Drawing.Size(450, 82);
            this.inputField5.TabIndex = 32;
            this.inputField5.Title = "Password";
            // 
            // inputField4
            // 
            this.inputField4.BackColor = System.Drawing.Color.Transparent;
            this.inputField4.Location = new System.Drawing.Point(17, 405);
            this.inputField4.Name = "inputField4";
            this.inputField4.PasswordCharType = '\0';
            this.inputField4.Size = new System.Drawing.Size(450, 82);
            this.inputField4.TabIndex = 31;
            this.inputField4.Title = "Phone Number";
            // 
            // inputField3
            // 
            this.inputField3.BackColor = System.Drawing.Color.Transparent;
            this.inputField3.Location = new System.Drawing.Point(17, 304);
            this.inputField3.Name = "inputField3";
            this.inputField3.PasswordCharType = '\0';
            this.inputField3.Size = new System.Drawing.Size(450, 82);
            this.inputField3.TabIndex = 30;
            this.inputField3.Title = "CNP";
            // 
            // inputField2
            // 
            this.inputField2.BackColor = System.Drawing.Color.Transparent;
            this.inputField2.Location = new System.Drawing.Point(17, 203);
            this.inputField2.Name = "inputField2";
            this.inputField2.PasswordCharType = '\0';
            this.inputField2.Size = new System.Drawing.Size(450, 82);
            this.inputField2.TabIndex = 29;
            this.inputField2.Title = "Email";
            // 
            // inputField1
            // 
            this.inputField1.BackColor = System.Drawing.Color.Transparent;
            this.inputField1.Location = new System.Drawing.Point(17, 102);
            this.inputField1.Name = "inputField1";
            this.inputField1.PasswordCharType = '\0';
            this.inputField1.Size = new System.Drawing.Size(450, 82);
            this.inputField1.TabIndex = 28;
            this.inputField1.Title = "Name";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel6);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.LinkLabel LnkToHomepage;
        private System.Windows.Forms.CheckBox CkBViewPassword;
        private System.Windows.Forms.LinkLabel LkLblLogIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private InputField inputField1;
        private InputField inputField2;
        private InputField inputField3;
        private InputField inputField4;
        private InputField inputField5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}