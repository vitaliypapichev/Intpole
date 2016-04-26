namespace WindowPolice
{
    partial class Interpole
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interpole));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspectTable = new System.Windows.Forms.DataGridView();
            this.SuspTable = new System.Windows.Forms.Label();
            this.KartelsGroup = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDrigViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuspectTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.mainToolStripMenuItem.Text = "Main Archive";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.archiveToolStripMenuItem.Text = "Find";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // SuspectTable
            // 
            this.SuspectTable.AllowUserToAddRows = false;
            this.SuspectTable.AllowUserToDeleteRows = false;
            this.SuspectTable.AllowUserToResizeColumns = false;
            this.SuspectTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SuspectTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SuspectTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SuspectTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SuspectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuspectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnName,
            this.DataDrigViewTextBoxColumnSurname,
            this.PatronymicDataGridViewTextBoxColumn,
            this.BirthDateDataGridViewTextBoxColumn,
            this.BirthPlaceDataGridViewTextBoxColumn});
            this.SuspectTable.GridColor = System.Drawing.Color.Black;
            this.SuspectTable.Location = new System.Drawing.Point(0, 57);
            this.SuspectTable.Name = "SuspectTable";
            this.SuspectTable.ReadOnly = true;
            this.SuspectTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuspectTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SuspectTable.Size = new System.Drawing.Size(543, 210);
            this.SuspectTable.TabIndex = 2;
            this.SuspectTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.SuspectTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // SuspTable
            // 
            this.SuspTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SuspTable.AutoSize = true;
            this.SuspTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SuspTable.CausesValidation = false;
            this.SuspTable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuspTable.Location = new System.Drawing.Point(12, 30);
            this.SuspTable.Name = "SuspTable";
            this.SuspTable.Size = new System.Drawing.Size(145, 24);
            this.SuspTable.TabIndex = 1;
            this.SuspTable.Text = "List of Suspects";
            this.SuspTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SuspTable.Click += new System.EventHandler(this.label1_Click);
            // 
            // KartelsGroup
            // 
            this.KartelsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.KartelsGroup.AutoSize = true;
            this.KartelsGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KartelsGroup.CausesValidation = false;
            this.KartelsGroup.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KartelsGroup.Location = new System.Drawing.Point(12, 304);
            this.KartelsGroup.Name = "KartelsGroup";
            this.KartelsGroup.Size = new System.Drawing.Size(211, 24);
            this.KartelsGroup.TabIndex = 3;
            this.KartelsGroup.Text = "Organazied Crime List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(543, 209);
            this.dataGridView1.TabIndex = 4;
            // 
            // DataGridViewTextBoxColumnName
            // 
            this.DataGridViewTextBoxColumnName.FillWeight = 253.8071F;
            this.DataGridViewTextBoxColumnName.HeaderText = "Name";
            this.DataGridViewTextBoxColumnName.MinimumWidth = 100;
            this.DataGridViewTextBoxColumnName.Name = "DataGridViewTextBoxColumnName";
            this.DataGridViewTextBoxColumnName.ReadOnly = true;
            this.DataGridViewTextBoxColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataDrigViewTextBoxColumnSurname
            // 
            this.DataDrigViewTextBoxColumnSurname.FillWeight = 17.58791F;
            this.DataDrigViewTextBoxColumnSurname.HeaderText = "Surname";
            this.DataDrigViewTextBoxColumnSurname.MinimumWidth = 100;
            this.DataDrigViewTextBoxColumnSurname.Name = "DataDrigViewTextBoxColumnSurname";
            this.DataDrigViewTextBoxColumnSurname.ReadOnly = true;
            this.DataDrigViewTextBoxColumnSurname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PatronymicDataGridViewTextBoxColumn
            // 
            this.PatronymicDataGridViewTextBoxColumn.FillWeight = 34.38072F;
            this.PatronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.PatronymicDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.PatronymicDataGridViewTextBoxColumn.Name = "PatronymicDataGridViewTextBoxColumn";
            this.PatronymicDataGridViewTextBoxColumn.ReadOnly = true;
            this.PatronymicDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BirthDateDataGridViewTextBoxColumn
            // 
            this.BirthDateDataGridViewTextBoxColumn.FillWeight = 129.7017F;
            this.BirthDateDataGridViewTextBoxColumn.HeaderText = "Years";
            this.BirthDateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.BirthDateDataGridViewTextBoxColumn.Name = "BirthDateDataGridViewTextBoxColumn";
            this.BirthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.BirthDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BirthPlaceDataGridViewTextBoxColumn
            // 
            this.BirthPlaceDataGridViewTextBoxColumn.FillWeight = 64.52259F;
            this.BirthPlaceDataGridViewTextBoxColumn.HeaderText = "Status";
            this.BirthPlaceDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.BirthPlaceDataGridViewTextBoxColumn.Name = "BirthPlaceDataGridViewTextBoxColumn";
            this.BirthPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.BirthPlaceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Interpole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.KartelsGroup);
            this.Controls.Add(this.SuspTable);
            this.Controls.Add(this.SuspectTable);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Interpole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Police Application";
            this.Load += new System.EventHandler(this.Interpole_Load);
            this.SizeChanged += new System.EventHandler(this.Interpole_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuspectTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.DataGridView SuspectTable;
        private System.Windows.Forms.Label SuspTable;
        private System.Windows.Forms.Label KartelsGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDrigViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlaceDataGridViewTextBoxColumn;

    }
}

