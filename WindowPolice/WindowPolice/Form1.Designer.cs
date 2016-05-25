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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interpole));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspectTable = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDrigViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Example = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuspTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuspectTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.mainToolStripMenuItem.Text = "Main Archive";
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
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // SuspectTable
            // 
            this.SuspectTable.AllowUserToAddRows = false;
            this.SuspectTable.AllowUserToDeleteRows = false;
            this.SuspectTable.AllowUserToResizeColumns = false;
            this.SuspectTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SuspectTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
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
            this.BirthPlaceDataGridViewTextBoxColumn,
            this.Example});
            this.SuspectTable.GridColor = System.Drawing.Color.Black;
            this.SuspectTable.Location = new System.Drawing.Point(4, 3);
            this.SuspectTable.Name = "SuspectTable";
            this.SuspectTable.ReadOnly = true;
            this.SuspectTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuspectTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SuspectTable.Size = new System.Drawing.Size(543, 210);
            this.SuspectTable.TabIndex = 2;
            this.SuspectTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuspectTable_CellDoubleClick);
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
            // Example
            // 
            this.Example.HeaderText = "ColWithSuspect";
            this.Example.Name = "Example";
            this.Example.ReadOnly = true;
            this.Example.Visible = false;
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
            this.SuspTable.Size = new System.Drawing.Size(143, 24);
            this.SuspTable.TabIndex = 1;
            this.SuspTable.Text = "List of suspects";
            this.SuspTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.SuspectTable);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 216);
            this.panel1.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 279);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Crimes";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(756, 271);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Time",
            "Today",
            "Week",
            "Month",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(568, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 29);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "All Time";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Interpole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SuspTable);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Interpole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Police Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Interpole_FormClosing);
            this.Load += new System.EventHandler(this.Interpole_Load);
            this.SizeChanged += new System.EventHandler(this.Interpole_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuspectTable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDrigViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Example;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}

