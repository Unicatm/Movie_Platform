namespace Proiect
{
    partial class FilmCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBTitlu = new System.Windows.Forms.Label();
            this.LBDescriere = new System.Windows.Forms.Label();
            this.BtnRezerva = new System.Windows.Forms.Button();
            this.PBImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LBTitlu
            // 
            this.LBTitlu.AutoSize = true;
            this.LBTitlu.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitlu.Location = new System.Drawing.Point(203, 22);
            this.LBTitlu.Name = "LBTitlu";
            this.LBTitlu.Size = new System.Drawing.Size(61, 36);
            this.LBTitlu.TabIndex = 0;
            this.LBTitlu.Text = "Titlu";
            // 
            // LBDescriere
            // 
            this.LBDescriere.AutoSize = true;
            this.LBDescriere.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDescriere.Location = new System.Drawing.Point(205, 68);
            this.LBDescriere.Name = "LBDescriere";
            this.LBDescriere.Size = new System.Drawing.Size(71, 23);
            this.LBDescriere.TabIndex = 1;
            this.LBDescriere.Text = "Descriere";
            // 
            // BtnRezerva
            // 
            this.BtnRezerva.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRezerva.Location = new System.Drawing.Point(197, 167);
            this.BtnRezerva.Name = "BtnRezerva";
            this.BtnRezerva.Size = new System.Drawing.Size(157, 35);
            this.BtnRezerva.TabIndex = 2;
            this.BtnRezerva.Text = "Rezerva";
            this.BtnRezerva.UseVisualStyleBackColor = true;
            // 
            // PBImage
            // 
            this.PBImage.Location = new System.Drawing.Point(27, 22);
            this.PBImage.Name = "PBImage";
            this.PBImage.Size = new System.Drawing.Size(143, 180);
            this.PBImage.TabIndex = 3;
            this.PBImage.TabStop = false;
            this.PBImage.Click += new System.EventHandler(this.PBImage_Click);
            // 
            // FilmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PBImage);
            this.Controls.Add(this.BtnRezerva);
            this.Controls.Add(this.LBDescriere);
            this.Controls.Add(this.LBTitlu);
            this.Name = "FilmCard";
            this.Size = new System.Drawing.Size(376, 219);
            this.Load += new System.EventHandler(this.FilmCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBTitlu;
        private System.Windows.Forms.Label LBDescriere;
        private System.Windows.Forms.Button BtnRezerva;
        private System.Windows.Forms.PictureBox PBImage;
    }
}
