namespace Proiect
{
    partial class Homepage
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
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Admin = new System.Windows.Forms.Button();
            this.BTNClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 141);
            this.label1.TabIndex = 0;
            this.label1.Text = "FilmFusion";
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogIn.Location = new System.Drawing.Point(6, 7);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.BtnLogIn.Size = new System.Drawing.Size(142, 56);
            this.BtnLogIn.TabIndex = 1;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.Location = new System.Drawing.Point(188, 7);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.BtnSignUp.Size = new System.Drawing.Size(142, 56);
            this.BtnSignUp.TabIndex = 2;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTNClient);
            this.panel1.Controls.Add(this.Admin);
            this.panel1.Location = new System.Drawing.Point(398, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 389);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSignUp);
            this.panel2.Controls.Add(this.BtnLogIn);
            this.panel2.Location = new System.Drawing.Point(511, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 71);
            this.panel2.TabIndex = 3;
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Crimson;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(20, 316);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.Admin.Size = new System.Drawing.Size(244, 56);
            this.Admin.TabIndex = 4;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // BTNClient
            // 
            this.BTNClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClient.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNClient.ForeColor = System.Drawing.Color.Crimson;
            this.BTNClient.Location = new System.Drawing.Point(284, 316);
            this.BTNClient.Name = "BTNClient";
            this.BTNClient.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.BTNClient.Size = new System.Drawing.Size(252, 56);
            this.BTNClient.TabIndex = 5;
            this.BTNClient.Text = "Client";
            this.BTNClient.UseVisualStyleBackColor = true;
            this.BTNClient.Click += new System.EventHandler(this.BTNClient_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button BTNClient;
    }
}

