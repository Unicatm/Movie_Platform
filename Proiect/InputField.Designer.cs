namespace Proiect
{
    partial class InputField
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
            this.LblInputReg = new System.Windows.Forms.Label();
            this.TxtBInputReg = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblInputReg
            // 
            this.LblInputReg.AutoSize = true;
            this.LblInputReg.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInputReg.Location = new System.Drawing.Point(0, 0);
            this.LblInputReg.Name = "LblInputReg";
            this.LblInputReg.Size = new System.Drawing.Size(65, 30);
            this.LblInputReg.TabIndex = 14;
            this.LblInputReg.Text = "Nume";
            // 
            // TxtBInputReg
            // 
            this.TxtBInputReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBInputReg.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBInputReg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtBInputReg.Location = new System.Drawing.Point(0, 33);
            this.TxtBInputReg.Multiline = true;
            this.TxtBInputReg.Name = "TxtBInputReg";
            this.TxtBInputReg.Size = new System.Drawing.Size(450, 40);
            this.TxtBInputReg.TabIndex = 13;
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.MidnightBlue;
            this.Line.Location = new System.Drawing.Point(0, 76);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(450, 1);
            this.Line.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LblInputReg);
            this.panel1.Controls.Add(this.TxtBInputReg);
            this.panel1.Controls.Add(this.Line);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 82);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InputField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "InputField";
            this.Size = new System.Drawing.Size(450, 82);
            this.Load += new System.EventHandler(this.InputField_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblInputReg;
        private System.Windows.Forms.TextBox TxtBInputReg;
        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.Panel panel1;
    }
}
