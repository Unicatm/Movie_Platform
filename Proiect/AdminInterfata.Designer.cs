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
            this.LVFilme = new System.Windows.Forms.ListView();
            this.id_film = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data_aparitie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filme_dbDS = new Proiect.filme_dbDS();
            this.filme_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filme_tblTableAdapter = new Proiect.filme_dbDSTableAdapters.filme_tblTableAdapter();
            this.tableAdapterManager = new Proiect.filme_dbDSTableAdapters.TableAdapterManager();
            this.filme_tblDataGridView = new System.Windows.Forms.DataGridView();
            this.idfilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LnkToHomepage = new System.Windows.Forms.LinkLabel();
            this.CMenuOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filme_dbDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme_tblDataGridView)).BeginInit();
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
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem,
            this.filmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 51);
            this.menuStrip1.TabIndex = 1;
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
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
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
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(133, 28);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // binarToolStripMenuItem1
            // 
            this.binarToolStripMenuItem1.Name = "binarToolStripMenuItem1";
            this.binarToolStripMenuItem1.Size = new System.Drawing.Size(133, 28);
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
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // LbAdminEmail
            // 
            this.LbAdminEmail.AutoSize = true;
            this.LbAdminEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LbAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAdminEmail.Location = new System.Drawing.Point(1070, 9);
            this.LbAdminEmail.Name = "LbAdminEmail";
            this.LbAdminEmail.Size = new System.Drawing.Size(173, 25);
            this.LbAdminEmail.TabIndex = 2;
            this.LbAdminEmail.Text = "admin@gmial.com";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LVFilme
            // 
            this.LVFilme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_film,
            this.titlu,
            this.descriere,
            this.stoc,
            this.data_aparitie,
            this.gen,
            this.durata});
            this.LVFilme.ContextMenuStrip = this.CMenuOperations;
            this.LVFilme.GridLines = true;
            this.LVFilme.HideSelection = false;
            this.LVFilme.Location = new System.Drawing.Point(36, 131);
            this.LVFilme.Name = "LVFilme";
            this.LVFilme.Size = new System.Drawing.Size(620, 700);
            this.LVFilme.TabIndex = 4;
            this.LVFilme.UseCompatibleStateImageBehavior = false;
            this.LVFilme.View = System.Windows.Forms.View.Details;
            // 
            // id_film
            // 
            this.id_film.Text = "Id";
            // 
            // titlu
            // 
            this.titlu.Text = "Titlu";
            // 
            // descriere
            // 
            this.descriere.Text = "Descriere";
            // 
            // stoc
            // 
            this.stoc.Text = "Stoc";
            // 
            // data_aparitie
            // 
            this.data_aparitie.Text = "Data aparitie";
            // 
            // gen
            // 
            this.gen.Text = "Gen";
            // 
            // durata
            // 
            this.durata.Text = "Durata";
            // 
            // filme_dbDS
            // 
            this.filme_dbDS.DataSetName = "filme_dbDS";
            this.filme_dbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filme_tblBindingSource
            // 
            this.filme_tblBindingSource.DataMember = "filme_tbl";
            this.filme_tblBindingSource.DataSource = this.filme_dbDS;
            // 
            // filme_tblTableAdapter
            // 
            this.filme_tblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.filme_tblTableAdapter = this.filme_tblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Proiect.filme_dbDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filme_tblDataGridView
            // 
            this.filme_tblDataGridView.AutoGenerateColumns = false;
            this.filme_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filme_tblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfilmDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.descriereDataGridViewTextBoxColumn,
            this.stocDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn,
            this.durataDataGridViewTextBoxColumn});
            this.filme_tblDataGridView.DataSource = this.filme_tblBindingSource;
            this.filme_tblDataGridView.Location = new System.Drawing.Point(693, 131);
            this.filme_tblDataGridView.Name = "filme_tblDataGridView";
            this.filme_tblDataGridView.RowHeadersWidth = 51;
            this.filme_tblDataGridView.RowTemplate.Height = 24;
            this.filme_tblDataGridView.Size = new System.Drawing.Size(560, 520);
            this.filme_tblDataGridView.TabIndex = 6;
            // 
            // idfilmDataGridViewTextBoxColumn
            // 
            this.idfilmDataGridViewTextBoxColumn.DataPropertyName = "id_film";
            this.idfilmDataGridViewTextBoxColumn.HeaderText = "id_film";
            this.idfilmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idfilmDataGridViewTextBoxColumn.Name = "idfilmDataGridViewTextBoxColumn";
            this.idfilmDataGridViewTextBoxColumn.Width = 125;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriereDataGridViewTextBoxColumn
            // 
            this.descriereDataGridViewTextBoxColumn.DataPropertyName = "descriere";
            this.descriereDataGridViewTextBoxColumn.HeaderText = "descriere";
            this.descriereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriereDataGridViewTextBoxColumn.Name = "descriereDataGridViewTextBoxColumn";
            this.descriereDataGridViewTextBoxColumn.Width = 125;
            // 
            // stocDataGridViewTextBoxColumn
            // 
            this.stocDataGridViewTextBoxColumn.DataPropertyName = "stoc";
            this.stocDataGridViewTextBoxColumn.HeaderText = "stoc";
            this.stocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stocDataGridViewTextBoxColumn.Name = "stocDataGridViewTextBoxColumn";
            this.stocDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // genDataGridViewTextBoxColumn
            // 
            this.genDataGridViewTextBoxColumn.DataPropertyName = "gen";
            this.genDataGridViewTextBoxColumn.HeaderText = "gen";
            this.genDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
            this.genDataGridViewTextBoxColumn.Width = 125;
            // 
            // durataDataGridViewTextBoxColumn
            // 
            this.durataDataGridViewTextBoxColumn.DataPropertyName = "durata";
            this.durataDataGridViewTextBoxColumn.HeaderText = "durata";
            this.durataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durataDataGridViewTextBoxColumn.Name = "durataDataGridViewTextBoxColumn";
            this.durataDataGridViewTextBoxColumn.Width = 125;
            // 
            // LnkToHomepage
            // 
            this.LnkToHomepage.AutoSize = true;
            this.LnkToHomepage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkToHomepage.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnkToHomepage.LinkColor = System.Drawing.Color.MidnightBlue;
            this.LnkToHomepage.Location = new System.Drawing.Point(127, 77);
            this.LnkToHomepage.Name = "LnkToHomepage";
            this.LnkToHomepage.Size = new System.Drawing.Size(53, 30);
            this.LnkToHomepage.TabIndex = 20;
            this.LnkToHomepage.TabStop = true;
            this.LnkToHomepage.Text = "Back";
            this.LnkToHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkToHomepage_LinkClicked);
            // 
            // AdminInterfata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1382, 853);
            this.Controls.Add(this.LnkToHomepage);
            this.Controls.Add(this.filme_tblDataGridView);
            this.Controls.Add(this.LVFilme);
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
            ((System.ComponentModel.ISupportInitialize)(this.filme_dbDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filme_tblDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
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
        private System.Windows.Forms.ListView LVFilme;
        private System.Windows.Forms.ColumnHeader id_film;
        private System.Windows.Forms.ColumnHeader titlu;
        private System.Windows.Forms.ColumnHeader descriere;
        private System.Windows.Forms.ColumnHeader stoc;
        private System.Windows.Forms.ColumnHeader data_aparitie;
        private System.Windows.Forms.ColumnHeader gen;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader durata;
        private filme_dbDS filme_dbDS;
        private System.Windows.Forms.BindingSource filme_tblBindingSource;
        private filme_dbDSTableAdapters.filme_tblTableAdapter filme_tblTableAdapter;
        private filme_dbDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView filme_tblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durataDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel LnkToHomepage;
    }
}