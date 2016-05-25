namespace WindowPolice
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CityDataGridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDATAgridView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityDataGridView,
            this.FactDataGrid,
            this.DataDATAgridView});
            this.dataGridView1.Location = new System.Drawing.Point(1, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // CityDataGridView
            // 
            this.CityDataGridView.HeaderText = "City";
            this.CityDataGridView.Name = "CityDataGridView";
            this.CityDataGridView.ReadOnly = true;
            // 
            // FactDataGrid
            // 
            this.FactDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FactDataGrid.HeaderText = "History";
            this.FactDataGrid.Name = "FactDataGrid";
            this.FactDataGrid.ReadOnly = true;
            // 
            // DataDATAgridView
            // 
            this.DataDATAgridView.HeaderText = "Date/Time";
            this.DataDATAgridView.MinimumWidth = 65;
            this.DataDATAgridView.Name = "DataDATAgridView";
            this.DataDATAgridView.ReadOnly = true;
            this.DataDATAgridView.Width = 65;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.Click += new System.EventHandler(this.Map_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDATAgridView;

    }
}