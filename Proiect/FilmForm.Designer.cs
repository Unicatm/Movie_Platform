namespace Proiect
{
    partial class FilmForm
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
            this.components = new System.ComponentModel.Container();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.DTAn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.CBGen = new System.Windows.Forms.ComboBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.TBDurata = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdauga = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TBStoc = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TBDescr = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TBId = new System.Windows.Forms.TextBox();
            this.LbHeader = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.filme_dbDS = new Proiect.filme_dbDS();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme_dbDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button1);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.BtnCancel);
            this.panel9.Controls.Add(this.BtnAdauga);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Location = new System.Drawing.Point(146, 139);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(490, 677);
            this.panel9.TabIndex = 47;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.DTAn);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Location = new System.Drawing.Point(17, 519);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(234, 71);
            this.panel12.TabIndex = 53;
            // 
            // DTAn
            // 
            this.DTAn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTAn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTAn.Location = new System.Drawing.Point(3, 44);
            this.DTAn.Name = "DTAn";
            this.DTAn.Size = new System.Drawing.Size(227, 26);
            this.DTAn.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "An lansare";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.CBGen);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Location = new System.Drawing.Point(257, 426);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(220, 86);
            this.panel13.TabIndex = 53;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // CBGen
            // 
            this.CBGen.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGen.FormattingEnabled = true;
            this.CBGen.Location = new System.Drawing.Point(3, 34);
            this.CBGen.Name = "CBGen";
            this.CBGen.Size = new System.Drawing.Size(214, 38);
            this.CBGen.TabIndex = 54;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel14.Location = new System.Drawing.Point(5, 77);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(279, 1);
            this.panel14.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 30);
            this.label7.TabIndex = 50;
            this.label7.Text = "Gen";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.TBDurata);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(17, 427);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(234, 86);
            this.panel11.TabIndex = 52;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel10.Location = new System.Drawing.Point(5, 77);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 1);
            this.panel10.TabIndex = 51;
            // 
            // TBDurata
            // 
            this.TBDurata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDurata.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDurata.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TBDurata.Location = new System.Drawing.Point(5, 31);
            this.TBDurata.Multiline = true;
            this.TBDurata.Name = "TBDurata";
            this.TBDurata.Size = new System.Drawing.Size(225, 40);
            this.TBDurata.TabIndex = 30;
            this.TBDurata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDurata_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 30);
            this.label6.TabIndex = 50;
            this.label6.Text = "Durata";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(256, 599);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.BtnCancel.Size = new System.Drawing.Size(218, 56);
            this.BtnCancel.TabIndex = 43;
            this.BtnCancel.Text = "Renunta";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAdauga
            // 
            this.BtnAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAdauga.Location = new System.Drawing.Point(17, 599);
            this.BtnAdauga.Name = "BtnAdauga";
            this.BtnAdauga.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.BtnAdauga.Size = new System.Drawing.Size(217, 56);
            this.BtnAdauga.TabIndex = 42;
            this.BtnAdauga.Text = "Adauga";
            this.BtnAdauga.UseVisualStyleBackColor = true;
            this.BtnAdauga.Click += new System.EventHandler(this.BtnAdauga_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.TBStoc);
            this.panel6.Location = new System.Drawing.Point(17, 337);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(457, 84);
            this.panel6.TabIndex = 38;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel8.Location = new System.Drawing.Point(3, 76);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(450, 1);
            this.panel8.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Stoc";
            // 
            // TBStoc
            // 
            this.TBStoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBStoc.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBStoc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TBStoc.Location = new System.Drawing.Point(3, 33);
            this.TBStoc.Multiline = true;
            this.TBStoc.Name = "TBStoc";
            this.TBStoc.Size = new System.Drawing.Size(450, 40);
            this.TBStoc.TabIndex = 28;
            this.TBStoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBStoc_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.TBDescr);
            this.panel4.Location = new System.Drawing.Point(17, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 133);
            this.panel4.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(3, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 1);
            this.panel3.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Descriere";
            // 
            // TBDescr
            // 
            this.TBDescr.Location = new System.Drawing.Point(3, 37);
            this.TBDescr.Name = "TBDescr";
            this.TBDescr.Size = new System.Drawing.Size(450, 84);
            this.TBDescr.TabIndex = 39;
            this.TBDescr.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbTitle);
            this.panel1.Location = new System.Drawing.Point(17, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 84);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(3, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 1);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Titlu";
            // 
            // TbTitle
            // 
            this.TbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbTitle.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TbTitle.Location = new System.Drawing.Point(3, 33);
            this.TbTitle.Multiline = true;
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(450, 40);
            this.TbTitle.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.TBId);
            this.panel5.Location = new System.Drawing.Point(17, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(473, 84);
            this.panel5.TabIndex = 37;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Location = new System.Drawing.Point(3, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(450, 1);
            this.panel7.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id";
            // 
            // TBId
            // 
            this.TBId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBId.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TBId.Location = new System.Drawing.Point(3, 33);
            this.TBId.Multiline = true;
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(450, 40);
            this.TBId.TabIndex = 28;
            this.TBId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBId_KeyPress);
            this.TBId.Validating += new System.ComponentModel.CancelEventHandler(this.TBId_Validating);
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeader.Location = new System.Drawing.Point(291, 68);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(200, 50);
            this.LbHeader.TabIndex = 48;
            this.LbHeader.Text = "Adauga film";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // filme_dbDS
            // 
            this.filme_dbDS.DataSetName = "filme_dbDS";
            this.filme_dbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(256, 533);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.button1.Size = new System.Drawing.Size(217, 56);
            this.button1.TabIndex = 54;
            this.button1.Text = "Adauga Imagine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 853);
            this.Controls.Add(this.LbHeader);
            this.Controls.Add(this.panel9);
            this.Name = "FilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilmForm";
            this.Load += new System.EventHandler(this.FilmForm_Load);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme_dbDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdauga;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBStoc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TBDescr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTAn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox TBDurata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox CBGen;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private filme_dbDS filme_dbDS;
        private System.Windows.Forms.Button button1;
    }
}