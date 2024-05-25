namespace Proiect
{
    partial class ClientInterfata
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
            this.LbAdminEmail = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlowLayoutFilmeClient = new System.Windows.Forms.FlowLayoutPanel();
            this.filmCard1 = new Proiect.FilmCard();
            this.menuStrip1.SuspendLayout();
            this.FlowLayoutFilmeClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbAdminEmail
            // 
            this.LbAdminEmail.AutoSize = true;
            this.LbAdminEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdminEmail.Location = new System.Drawing.Point(1069, 9);
            this.LbAdminEmail.Name = "LbAdminEmail";
            this.LbAdminEmail.Size = new System.Drawing.Size(165, 25);
            this.LbAdminEmail.TabIndex = 4;
            this.LbAdminEmail.Text = "client@gmial.com";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem,
            this.filmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 51);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.binarToolStripMenuItem});
            this.salvareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 20, 25, 0);
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(118, 47);
            this.salvareToolStripMenuItem.Text = "Salvare";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.binarToolStripMenuItem.Text = "Binar";
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.binarToolStripMenuItem1});
            this.restaurareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(145, 47);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(133, 28);
            this.xMLToolStripMenuItem1.Text = "XML";
            // 
            // binarToolStripMenuItem1
            // 
            this.binarToolStripMenuItem1.Name = "binarToolStripMenuItem1";
            this.binarToolStripMenuItem1.Size = new System.Drawing.Size(133, 28);
            this.binarToolStripMenuItem1.Text = "Binar";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem});
            this.filmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(95, 47);
            this.filmToolStripMenuItem.Text = "Film";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // FlowLayoutFilmeClient
            // 
            this.FlowLayoutFilmeClient.Controls.Add(this.filmCard1);
            this.FlowLayoutFilmeClient.Location = new System.Drawing.Point(35, 96);
            this.FlowLayoutFilmeClient.Name = "FlowLayoutFilmeClient";
            this.FlowLayoutFilmeClient.Size = new System.Drawing.Size(1313, 733);
            this.FlowLayoutFilmeClient.TabIndex = 5;
            // 
            // filmCard1
            // 
            this.filmCard1.BackColor = System.Drawing.Color.White;
            this.filmCard1.Location = new System.Drawing.Point(3, 3);
            this.filmCard1.Name = "filmCard1";
            this.filmCard1.Size = new System.Drawing.Size(376, 219);
            this.filmCard1.TabIndex = 0;
            // 
            // ClientInterfata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.FlowLayoutFilmeClient);
            this.Controls.Add(this.LbAdminEmail);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ClientInterfata";
            this.Text = "ClientInterfata";
            this.Load += new System.EventHandler(this.ClientInterfata_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FlowLayoutFilmeClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAdminEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutFilmeClient;
        private FilmCard filmCard1;
    }
}