using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowPolice
{
    public partial class Interpole : Form
    {
        private SuspectCollection suspects;
        public Interpole() : base()
        {
            InitializeComponent();
            suspects = new SuspectCollection();
        }
        private void Interpole_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if(login.ShowDialog() != DialogResult.None)
            {
                suspects.FillSuspectCollection();
                SuspectTable.Rows.Clear();
                Methods.PutActiveIntoTable(SuspectTable, suspects);
                FindStatistic("All Time");
            }
        }
        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormForSearching search = new FormForSearching(this.suspects, SuspectTable);
            search.Location = this.Location;
            if(search.ShowDialog() == DialogResult.OK)
            {
                search.Close();
            }
        }
        private void Interpole_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SuspectTable.Columns.Count; i++)
            {
                SuspectTable.Columns[i].MinimumWidth = Convert.ToInt32(Math.Floor(this.Width / 7.93));
            }
            SuspectTable.Width = Convert.ToInt32(Math.Floor(this.Width / 1.4732965009208103130755064456722));
            SuspectTable.Height = Convert.ToInt32(Math.Floor(this.Height / 2.8571428571428571428571428571429));
            panel1.Width = SuspectTable.Width + 7;
            panel1.Height = SuspectTable.Height + 7;
        }
        private void SuspectTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow cell = this.SuspectTable.Rows[e.RowIndex];
            }
            catch(ArgumentOutOfRangeException ex)
            {
                return;
            }
            DataGridViewRow cells = this.SuspectTable.Rows[e.RowIndex];
            Inform form = new Inform(suspects.ElementAt(Convert.ToInt32(cells.Cells[cells.Cells.Count - 1].Value)));
            Dictionary<string, string> Dict = suspects.ElementAt(Convert.ToInt32(cells.Cells[cells.Cells.Count - 1].Value)).ReturnData();
            for (int i = 0; i < form.Controls.Count; i++)
            {
                foreach(KeyValuePair<string, string> comparer in Dict)
                {
                    if (form.Controls[i].Text.Equals(comparer.Key))
                        form.Controls[i].Text = comparer.Value;
                    if (form.Controls[i].Name.Equals(comparer.Key) && form.Controls[i].Name.Equals("Photo"))
                    {
                        PictureBox box = new PictureBox();
                        box = (PictureBox)form.Controls[i];
                        Bitmap Img = new Bitmap(comparer.Value);
                        box.Image = Img;
                        box.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (comparer.Key.Equals("Status") && form.Controls[i].Name.Equals("InterpolAction"))
                    {
                        PictureBox box = new PictureBox();
                        box = (PictureBox)form.Controls[i];
                        Bitmap Img;
                        if (comparer.Value == "In Jail")
                        {
                            Img = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\busted.png");
                            box.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            Img = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\LOGO_WANTED_V3_TORCIDO_ROJO.png");
                            box.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        box.Image = Img;
                    }
                }
            }
            if(form.ShowDialog() != DialogResult.None)
            {
                this.chart1.Series[0].Points.Clear();
                FindStatistic(comboBox1.Text);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adding AddForm = new Adding(SuspectTable,suspects);
            AddForm.Show();
        }
        private void Interpole_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream file = new FileStream(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\DataBases\suspects.ipd", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            foreach(Suspect Susp in suspects)
            {
                 writer.WriteLine(Susp.ToString());
            }
            writer.Close();
            file.Close();
        }
        private void FindStatistic(string Time)
        {
            string[] crimes = { "PropertyCrime", "LifeThreat", "Hacking", "Terrorism", "Hijacking", "Corruption", "Drugs" };
            int[] count = new int[crimes.Length];
            for (int i = 0; i < crimes.Length; i++)
            {
                foreach(Suspect compr in suspects)
                {
                    foreach(KeyValuePair<Crime,DateTime> comparer in compr.Crimes)
                    {
                        if (Time.Equals("Today"))
                        {
                            if (comparer.Key.GetTypeName().Equals(crimes[i]) && DateTime.Today.ToString("dd/MM/yyyy").Equals(comparer.Value.ToString("dd/MM/yyyy")))
                                count[i] = count[i] + 1;
                        }
                        if(Time.Equals("Week"))
                        {
                            if (comparer.Key.GetTypeName().Equals(crimes[i]) && comparer.Value.Day >= DateTime.Today.Day - 7 && comparer.Value.Year == DateTime.Today.Year && comparer.Value.Month == DateTime.Today.Month)
                                count[i] = count[i] + 1;
                        }
                        if (Time.Equals("Month"))
                        {
                            if (comparer.Key.GetTypeName().Equals(crimes[i]) && comparer.Value.Year == DateTime.Today.Year && comparer.Value.Month == DateTime.Today.Month)
                                count[i] = count[i] + 1;
                        }
                        if (Time.Equals("Year"))
                        {
                            if (comparer.Key.GetTypeName().Equals(crimes[i]) && comparer.Value.Year == DateTime.Today.Year)
                                count[i] = count[i] + 1;
                        }
                        if(Time.Equals("All Time"))
                        {
                            if(comparer.Key.GetTypeName().Equals(crimes[i]))
                                count[i] = count[i] + 1;
                        }
                    }
                }
            }
            for (int i = 0; i < count.Length; i++)
                this.chart1.Series["Crimes"].Points.AddXY(crimes[i], count[i]);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            FindStatistic(comboBox1.Text);
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuspectTable.Rows.Clear();
            Methods.PutActiveIntoTable(SuspectTable, suspects);
        }

    }
}
