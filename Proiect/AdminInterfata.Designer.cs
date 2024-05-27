namespace Proiect
{
    partial class AdminInterfata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterfata));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CMenuOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LbAdminEmail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filme_tblDataGridView = new System.Windows.Forms.DataGridView();
            this.filmetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmeDataSetF = new Proiect.filmeDataSetF();
            this.LnkToHomepage = new System.Windows.Forms.LinkLabel();
            this.filme_tblTableAdapter = new Proiect.filmeDataSetFTableAdapters.filme_tblTableAdapter();
            this.idfilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapubliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.CMenuOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filme_tblDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeDataSetF)).BeginInit();
            this.SuspendLayout();
            // 
            // CMenuOperations
            // 
            this.CMenuOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMenuOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.CMenuOperations.Name = "CMenuOperations";
            this.CMenuOperations.Size = new System.Drawing.Size(136, 76);
            this.CMenuOperations.Opening += new System.ComponentModel.CancelEventHandler(this.CMenuOperations_Opening);
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.editeazaToolStripMenuItem.Text = "Editeaza";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Crimson;
            this.menuStrip1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem,
            this.filmToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1382, 51);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.binarToolStripMenuItem});
            this.salvareToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.salvareToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Padding = new System.Windows.Forms.Padding(25, 20, 25, 0);
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(118, 47);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.binarToolStripMenuItem.Text = "Binar";
            this.binarToolStripMenuItem.Click += new System.EventHandler(this.binarToolStripMenuItem_Click);
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
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // binarToolStripMenuItem1
            // 
            this.binarToolStripMenuItem1.Name = "binarToolStripMenuItem1";
            this.binarToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.binarToolStripMenuItem1.Text = "Binar";
            this.binarToolStripMenuItem1.Click += new System.EventHandler(this.binarToolStripMenuItem1_Click);
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
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // LbAdminEmail
            // 
            this.LbAdminEmail.AutoSize = true;
            this.LbAdminEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdminEmail.Location = new System.Drawing.Point(1185, 9);
            this.LbAdminEmail.Name = "LbAdminEmail";
            this.LbAdminEmail.Size = new System.Drawing.Size(173, 25);
            this.LbAdminEmail.TabIndex = 2;
            this.LbAdminEmail.Text = "admin@gmial.com";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1302, 76);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filme_tblDataGridView
            // 
            this.filme_tblDataGridView.AllowUserToAddRows = false;
            this.filme_tblDataGridView.AllowUserToDeleteRows = false;
            this.filme_tblDataGridView.AutoGenerateColumns = false;
            this.filme_tblDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filme_tblDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.filme_tblDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filme_tblDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filme_tblDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.filme_tblDataGridView.ColumnHeadersHeight = 30;
            this.filme_tblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfilmDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.datapubliDataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn,
            this.bucDataGridViewTextBoxColumn,
            this.imgDataGridViewImageColumn});
            this.filme_tblDataGridView.ContextMenuStrip = this.CMenuOperations;
            this.filme_tblDataGridView.DataSource = this.filmetblBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.filme_tblDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.filme_tblDataGridView.GridColor = System.Drawing.Color.LightCoral;
            this.filme_tblDataGridView.Location = new System.Drawing.Point(27, 131);
            this.filme_tblDataGridView.MultiSelect = false;
            this.filme_tblDataGridView.Name = "filme_tblDataGridView";
            this.filme_tblDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.filme_tblDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.filme_tblDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.filme_tblDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.filme_tblDataGridView.RowTemplate.Height = 24;
            this.filme_tblDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filme_tblDataGridView.Size = new System.Drawing.Size(1315, 423);
            this.filme_tblDataGridView.TabIndex = 6;
            this.filme_tblDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filme_tblDataGridView_CellContentClick);
            this.filme_tblDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.filme_tblDataGridView_CellEnter);
            // 
            // filmetblBindingSource
            // 
            this.filmetblBindingSource.DataMember = "filme_tbl";
            this.filmetblBindingSource.DataSource = this.filmeDataSetF;
            // 
            // filmeDataSetF
            // 
            this.filmeDataSetF.DataSetName = "filmeDataSetF";
            this.filmeDataSetF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LnkToHomepage
            // 
            this.LnkToHomepage.AutoSize = true;
            this.LnkToHomepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkToHomepage.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkToHomepage.LinkColor = System.Drawing.Color.MidnightBlue;
            this.LnkToHomepage.Location = new System.Drawing.Point(22, 76);
            this.LnkToHomepage.Name = "LnkToHomepage";
            this.LnkToHomepage.Size = new System.Drawing.Size(53, 30);
            this.LnkToHomepage.TabIndex = 20;
            this.LnkToHomepage.TabStop = true;
            this.LnkToHomepage.Text = "Back";
            this.LnkToHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkToHomepage_LinkClicked);
            // 
            // filme_tblTableAdapter
            // 
            this.filme_tblTableAdapter.ClearBeforeFill = true;
            // 
            // idfilmDataGridViewTextBoxColumn
            // 
            this.idfilmDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idfilmDataGridViewTextBoxColumn.DataPropertyName = "id_film";
            this.idfilmDataGridViewTextBoxColumn.HeaderText = "id_film";
            this.idfilmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idfilmDataGridViewTextBoxColumn.Name = "idfilmDataGridViewTextBoxColumn";
            this.idfilmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "Descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datapubliDataGridViewTextBoxColumn
            // 
            this.datapubliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datapubliDataGridViewTextBoxColumn.DataPropertyName = "data_publi";
            this.datapubliDataGridViewTextBoxColumn.HeaderText = "Data release";
            this.datapubliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datapubliDataGridViewTextBoxColumn.Name = "datapubliDataGridViewTextBoxColumn";
            this.datapubliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genDataGridViewTextBoxColumn
            // 
            this.genDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genDataGridViewTextBoxColumn.DataPropertyName = "gen";
            this.genDataGridViewTextBoxColumn.HeaderText = "Gen";
            this.genDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
            this.genDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bucDataGridViewTextBoxColumn
            // 
            this.bucDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bucDataGridViewTextBoxColumn.DataPropertyName = "buc";
            this.bucDataGridViewTextBoxColumn.HeaderText = "Bucati";
            this.bucDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bucDataGridViewTextBoxColumn.Name = "bucDataGridViewTextBoxColumn";
            this.bucDataGridViewTextBoxColumn.ReadOnly = true;
            this.bucDataGridViewTextBoxColumn.Width = 98;
            // 
            // imgDataGridViewImageColumn
            // 
            this.imgDataGridViewImageColumn.DataPropertyName = "img";
            this.imgDataGridViewImageColumn.HeaderText = "img";
            this.imgDataGridViewImageColumn.MinimumWidth = 6;
            this.imgDataGridViewImageColumn.Name = "imgDataGridViewImageColumn";
            this.imgDataGridViewImageColumn.ReadOnly = true;
            // 
            // AdminInterfata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.LnkToHomepage);
            this.Controls.Add(this.filme_tblDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbAdminEmail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminInterfata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInterfata";
            this.Load += new System.EventHandler(this.AdminInterfata_Load);
            this.CMenuOperations.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filme_tblDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmeDataSetF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.Label LbAdminEmail;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip CMenuOperations;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem1;
        private System.Windows.Forms.DataGridView filme_tblDataGridView;
        private System.Windows.Forms.LinkLabel LnkToHomepage;
        private filmeDataSetF filmeDataSetF;
        private System.Windows.Forms.BindingSource filmetblBindingSource;
        private filmeDataSetFTableAdapters.filme_tblTableAdapter filme_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapubliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
    }
}