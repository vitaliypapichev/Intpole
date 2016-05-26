﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPolice
{
    public partial class EditingForm : Form
    {
        private Suspect suspected;
        public EditingForm(Suspect Suspected)
        {
            InitializeComponent();
            suspected = Suspected;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "PropCrime": comboBox2.Items.Clear(); Methods.FindInFileCrime("pc", comboBox2); break;
                case "LifeThreat": comboBox2.Items.Clear(); Methods.FindInFileCrime("lt", comboBox2); break;
                case "Hacking": comboBox2.Items.Clear(); Methods.FindInFileCrime("hk", comboBox2); break;
                case "Hijacking": comboBox2.Items.Clear(); Methods.FindInFileCrime("hj", comboBox2); break;
                case "Corruption": comboBox2.Items.Clear(); Methods.FindInFileCrime("ct", comboBox2); break;
                case "Drugs": comboBox2.Items.Clear(); Methods.FindInFileCrime("dg", comboBox2); break;
                case "Terrorism": comboBox2.Items.Clear(); Methods.FindInFileCrime("tr", comboBox2); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Crime") || comboBox2.Text.Length == 0)
                return;
            suspected.Crimes.Add(Methods.SetCrime(comboBox1.Text + ">" + comboBox2.Text, '>'), dateTimePicker1.Value);
            fillTableWithCrimes();
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            suspected.Status = comboBox5.Text;
        }
        private void EditingForm_Load(object sender, EventArgs e)
        {
            fillTableWithCrimes();
            fillTableWithEvents();
            textBox2.Text = suspected.SearchedIn;
            Methods.FindRegions(suspected.SearchedIn, comboBox4);
            pictureBox1.Image = new Bitmap(suspected.PicLoc);
            comboBox5.Text = suspected.Status;
            checkBox1.Checked = suspected.IfWife;
            checkBox2.Checked = suspected.IfChildren;
        }
        private void fillTableWithCrimes()
        {
            dataGridView1.Rows.Clear();
            foreach (KeyValuePair<Crime, DateTime> comparer in suspected.Crimes)
            {
                dataGridView1.Rows.Add(comparer.Key.ToString(), comparer.Value.ToString("dd/MM/yyyy"));
            }
        }
        private void fillTableWithEvents()
        {
            dataGridView2.Rows.Clear();
            foreach (Story comparer in suspected.History)
            {
                dataGridView2.Rows.Add(comparer.State + '>' + comparer.Place, comparer.Fact, comparer.Date.ToString("dd/MM/yyyy"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || comboBox4.Text.Length == 0 || textBox3.Text.Length == 0)
                return;
            suspected.History.Add(new Story(comboBox4.Text + '>' + textBox3.Text + '#' + textBox1.Text + '=' + dateTimePicker1.Value.ToString("dd/MM/yyyy")));
            fillTableWithEvents();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (suspected.History.Count == 1)
            {
                MessageBox.Show("Impossible to delete all history");
                return;
            }
            try
            {
                DataGridViewRow cell = this.dataGridView2.Rows[e.RowIndex];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return;
            }
            DataGridViewRow celll = this.dataGridView2.Rows[e.RowIndex];
            dataGridView2.Rows.Remove(celll);
            suspected.History.Remove(suspected.History.ElementAt(e.RowIndex));
            fillTableWithEvents();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (suspected.Crimes.Count == 1)
            {
                MessageBox.Show("Impossible to delete all crimes");
                return;
            }
            try
            {
                DataGridViewRow cell = this.dataGridView1.Rows[e.RowIndex];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return;
            }
            DataGridViewRow celll = this.dataGridView1.Rows[e.RowIndex];
            dataGridView1.Rows.Remove(celll);
            suspected.Crimes.Remove(suspected.Crimes.ElementAt(e.RowIndex).Key);
            fillTableWithCrimes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(@"" + openFileDialog1.InitialDirectory + openFileDialog1.FileName);
                suspected.PicLoc = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
            else
            {
                suspected.PicLoc = "-";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            suspected.IfWife = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            suspected.IfChildren = checkBox1.Checked;
        }
    }
}
