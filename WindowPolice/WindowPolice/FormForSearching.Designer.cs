namespace WindowPolice
{
    partial class FormForSearching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForSearching));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KIA = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspectRadio = new System.Windows.Forms.RadioButton();
            this.GroupRadio = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(31, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(153, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // KIA
            // 
            this.KIA.AutoSize = true;
            this.KIA.BackColor = System.Drawing.Color.White;
            this.KIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KIA.Location = new System.Drawing.Point(12, 136);
            this.KIA.Name = "KIA";
            this.KIA.Size = new System.Drawing.Size(142, 20);
            this.KIA.TabIndex = 2;
            this.KIA.Text = "Was killed in action";
            this.KIA.UseVisualStyleBackColor = false;
            this.KIA.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SuspectRadio
            // 
            this.SuspectRadio.AutoSize = true;
            this.SuspectRadio.BackColor = System.Drawing.Color.White;
            this.SuspectRadio.Checked = true;
            this.SuspectRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuspectRadio.ForeColor = System.Drawing.Color.Black;
            this.SuspectRadio.Location = new System.Drawing.Point(12, 87);
            this.SuspectRadio.Name = "SuspectRadio";
            this.SuspectRadio.Size = new System.Drawing.Size(113, 20);
            this.SuspectRadio.TabIndex = 1;
            this.SuspectRadio.TabStop = true;
            this.SuspectRadio.Text = "Find a suspect";
            this.SuspectRadio.UseVisualStyleBackColor = false;
            this.SuspectRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // GroupRadio
            // 
            this.GroupRadio.AutoSize = true;
            this.GroupRadio.BackColor = System.Drawing.Color.White;
            this.GroupRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupRadio.Location = new System.Drawing.Point(12, 180);
            this.GroupRadio.Name = "GroupRadio";
            this.GroupRadio.Size = new System.Drawing.Size(137, 20);
            this.GroupRadio.TabIndex = 4;
            this.GroupRadio.TabStop = true;
            this.GroupRadio.Text = "Find a crime group";
            this.GroupRadio.UseVisualStyleBackColor = false;
            this.GroupRadio.CheckedChanged += new System.EventHandler(this.GroupRadio_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 24);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 380);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormForSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(646, 391);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.GroupRadio);
            this.Controls.Add(this.SuspectRadio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KIA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormForSearching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Searching";
            this.Load += new System.EventHandler(this.FormForSearching_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox KIA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton SuspectRadio;
        private System.Windows.Forms.RadioButton GroupRadio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}