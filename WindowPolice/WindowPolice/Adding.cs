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
using System.Threading;

namespace WindowPolice
{

    public partial class Adding : Form
    {
        private List<string> crimes;
        private List<string> story;
        private DateTime crimedate;
        private DateTime lastseen;
        private string photo;
        private SuspectCollection suspect;
        private DataGridView table;
        public Adding(DataGridView Table, SuspectCollection Susp)
        {
            InitializeComponent();
            crimes = new List<string>();
            story = new List<string>();
            photo = "";
            crimedate = new DateTime();
            lastseen = new DateTime();
            suspect = Susp;
            this.table = Table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(@""+openFileDialog1.InitialDirectory + openFileDialog1.FileName);
                this.photo = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
            else
            {
                this.photo = "-";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CrimeType = '>' +comboBox2.Text;
            if(comboBox1.Text.ToLower().IndexOf("crime") != -1)
            {
                CrimeType = "PropCrime" + CrimeType;
            }
            else
            {
                if(comboBox1.Text.ToLower().IndexOf("life") != -1)
                    CrimeType = "LifeThreat" + CrimeType;
                else
                    CrimeType = comboBox1.Text + CrimeType;
            }
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            if (CrimeType == ">" || date == "")
                return;
            CheckForDateCrime(dateTimePicker1.Value);
            crimes.Add(CrimeType + ':' + date);
            dataGridView1.Rows.Add(comboBox1.Text + '>' + comboBox2.Text, date);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Property Crime": comboBox2.Items.Clear(); Methods.FindInFileCrime("pc", comboBox2); break;
                case "Life Threat": comboBox2.Items.Clear(); Methods.FindInFileCrime("lt", comboBox2); break;
                case "Hacking": comboBox2.Items.Clear(); Methods.FindInFileCrime("hk", comboBox2); break;
                case "Hijacking": comboBox2.Items.Clear(); Methods.FindInFileCrime("hj", comboBox2); break;
                case "Corruption": comboBox2.Items.Clear(); Methods.FindInFileCrime("ct", comboBox2); break;
                case "Drugs": comboBox2.Items.Clear(); Methods.FindInFileCrime("dg", comboBox2); break;
                case "Terrorism": comboBox2.Items.Clear(); Methods.FindInFileCrime("tr", comboBox2); break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Methods.FindRegions(searchedin.Text, comboBox3);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
            crimes.Remove(crimes.ElementAt(crimes.Count - 1 - e.RowIndex));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string city = comboBox3.Text + '>' + textBox6.Text;
            string story = textBox3.Text;
            string date = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            if (city == ">" || story == "" || date == "")
                return;
            CheckForDateStory(dateTimePicker2.Value);
            dataGridView2.Rows.Add(city, story, date);
            this.story.Add(city + '#' + story + '=' + date);
            Methods.PutActiveIntoTable(table, suspect);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
            story.Remove(story.ElementAt(story.Count - 1 - e.RowIndex));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count-1; i >= 0 ; i--)
            {
                if(this.Controls[i].GetType().Name.ToLower().Equals("textbox"))
                {
                    if(this.Controls[i].Text.Length == 0)
                    {
                        if (!this.Controls[i].Name.Equals("textBox3") && !this.Controls[i].Name.Equals("textBox6")) 
                        { 
                            this.Controls[i].BackColor = Color.FromArgb(255, 128, 128);
                            return;
                        }
                    }
                }
            }
            if (crimes.Count == 0 && story.Count == 0)
                return;
            string[] pointers = { "name", "surname", "patro", "birth", "placeofb", "build", "hair", "eyes", "height", this.crimes.Count.ToString(), FindLastCrime(), "wife", "children", FindLastPos(), CrimesToString(), "searchedin", "status", this.photo, StoryToString() };
            for (int i = 0; i < pointers.Length; i++ )
            {
                for(int j = 0; j < this.Controls.Count; j++)
                {
                    if(this.Controls[j].Name.Equals(pointers[i]) && this.Controls[j].GetType().Name.ToLower().Equals("textbox"))
                        pointers[i] = this.Controls[j].Text;
                    if (this.Controls[j].Name.Equals(pointers[i]) && this.Controls[j].GetType().Name.ToLower().Equals("combobox"))
                        pointers[i] = this.Controls[j].Text.Trim();
                    if (this.Controls[j].Name.Equals(pointers[i]) && this.Controls[j].GetType().Name.ToLower().Equals("checkbox"))
                        pointers[i] = ((CheckBox)this.Controls[j]).Checked.ToString();
                    if (this.Controls[j].Name.Equals(pointers[i]) && this.Controls[j].GetType().Name.ToLower().Equals("monthcalendar"))
                        pointers[i] = ((MonthCalendar)this.Controls[j]).SelectionRange.Start.ToString("dd/MM/yyyy");
                    if (this.Controls[j].Name.Equals(pointers[i]) && this.Controls[j].GetType().Name.ToLower().Equals("numericupdown"))
                        pointers[i] = ((NumericUpDown)this.Controls[j]).Value.ToString();
                }
            }
            suspect.Add(new Suspect(String.Join("~", pointers)));
            Methods.PutActiveIntoTable(table, suspect);
            this.Close();
        }
        private string FindLastCrime()
        {
            foreach(string comparer in crimes)
            {
                if (comparer.IndexOf(crimedate.ToString("dd/MM/yyyy")) != -1)
                return comparer.Substring(0, comparer.IndexOf(':'));
            }
            return crimedate.ToString("dd/MM/yyyy");
        }
        private string CrimesToString()
        {
            string result = "";
            bool point = false;
            foreach(string comparer in crimes)
            {
                if(point)
                result += ", ";
                result += comparer;
                point = true;
            }
            return result;
        }
        private void CheckForDateCrime(DateTime time1)
        {
            if (time1.Year > crimedate.Year)
            {
                crimedate = time1;
                return;
            }
            if (time1.Year == crimedate.Year)
            {
                if (time1.Month > crimedate.Month)
                {
                    crimedate = time1;
                    return;
                }
                if (time1.Month == crimedate.Month)
                {
                    if (time1.Day > crimedate.Day)
                    {
                        crimedate = time1;
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        private void CheckForDateStory(DateTime time1)
        {
            if (time1.Year > lastseen.Year)
            {
                lastseen = time1;
                return;
            }
            if (time1.Year == lastseen.Year)
            {
                if (time1.Month > lastseen.Month)
                {
                    lastseen = time1;
                    return;
                }
                if (time1.Month == lastseen.Month)
                {
                    if (time1.Day > lastseen.Day)
                    {
                        lastseen = time1;
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        private string StoryToString()
        {
            string result = "";
            bool point = false;
            foreach (string comparer in story)
            {
                if (point)
                    result += ';';
                result += comparer;
                point = true;
            }
            return result;
        }
        private string FindLastPos()
        {
            foreach (string comparer in story)
            {
                if (comparer.IndexOf(lastseen.ToString("dd/MM/yyyy")) != -1)
                    return comparer.Substring(0, comparer.IndexOf('#'));
            }
            return lastseen.ToString("dd/MM/yyyy");
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            name.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            surname.BackColor = Color.White;
        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            patro.BackColor = Color.White;
        }

        private void textBox13_Enter(object sender, EventArgs e)
        {
            eyes.BackColor = Color.White;
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            build.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            hair.BackColor = Color.White;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            placeofb.BackColor = Color.White;
        }
    }
}
