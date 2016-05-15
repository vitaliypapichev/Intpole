using System;
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
    public partial class Interpole : Form
    {
        private SuspectCollection Suspects;
        private KIACollection KilledInAction;
        public Interpole() : base()
        {
            InitializeComponent();
            Suspects = new SuspectCollection();
            KilledInAction = new KIACollection();
        }
        private void Interpole_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if(login.ShowDialog() != DialogResult.None)
            {             
                Suspects.FillSuspectCollection();
                KilledInAction.FillCollection();
                Methods.PutActiveIntoTable(SuspectTable, Suspects);
            }
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormForSearching a = new FormForSearching();
            a.Location = this.Location;
            if(a.ShowDialog() == DialogResult.OK)
            {
                a.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void suspectBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

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
            dataGridView1.Width = SuspectTable.Width;
            dataGridView1.Height = SuspectTable.Height;
            panel2.Width = dataGridView1.Width + 7;
            panel2.Height = dataGridView1.Height + 7;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (KIA.Checked == true)
            {
                SuspectTable.Rows.Clear();
                SuspTable.Text = "KIA List";
                Methods.PutActiveIntoTable(SuspectTable, KilledInAction);
            }
            else
            {
                SuspectTable.Rows.Clear();
                SuspTable.Text = "List of Suspects";
                Methods.PutActiveIntoTable(SuspectTable, Suspects);
            }
            KIA.Location = new Point(SuspTable.Location.X + 7 + SuspTable.Width, KIA.Location.Y);
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
            DataGridViewRow celll = this.SuspectTable.Rows[e.RowIndex];
            Inform form = new Inform();
            Dictionary<string, string> Dict = Suspects.ElementAt(Convert.ToInt32(celll.Cells[celll.Cells.Count - 1].Value)).ReturnData();
            for (int i = 0; i < form.Controls.Count; i++)
            {
                foreach(KeyValuePair<string,string> KValue in Dict)
                {
                    if (form.Controls[i].Text.Equals(KValue.Key))
                        form.Controls[i].Text = KValue.Value;
                    if (form.Controls[i].Name.Equals(KValue.Key) && form.Controls[i].Name.Equals("Photo"))
                    {
                        PictureBox box = new PictureBox();
                        box = (PictureBox)form.Controls[i];
                        Bitmap Img = new Bitmap(KValue.Value);
                        box.Image = Img;
                        box.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if(form.Controls[i].Name.Equals("Flag") && KValue.Key.Equals("Place of birth"))
                    {
                        string country = KValue.Value.Substring(KValue.Value.IndexOf(',') + 2);
                        PictureBox box = new PictureBox();
                        box = (PictureBox)form.Controls[i];
                        Bitmap Img;
                        try
                        {
                            Img = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\\" + country + ".png");
                        }
                        catch (System.Exception exe)
                        {
                            Img = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\image-not-found-4a963b95bf081c3ea02923dceaeb3f8085e1a654fc54840aac61a57a60903fef.png");
                        }
                        box.Image = Img;
                        box.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (form.Controls[i].Name.Equals("FlagNext") && KValue.Key.Equals("Was last seen"))
                    {
                        string country = KValue.Value.Substring(KValue.Value.IndexOf(',') + 2);
                        PictureBox box = new PictureBox();
                        box = (PictureBox)form.Controls[i];
                        Bitmap Img;
                        try
                        {
                            Img = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\\" + country + ".png");
                        }
                        catch (System.Exception exe)
                        {
                            Img = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\image-not-found-4a963b95bf081c3ea02923dceaeb3f8085e1a654fc54840aac61a57a60903fef.png");
                        }
                        box.Image = Img;
                        box.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    if (KValue.Key.Equals("Status") && form.Controls[i].Name.Equals("InterpolAction"))
                    {
                        PictureBox box = new PictureBox();
                        box = (PictureBox)form.Controls[i];
                        Bitmap Img;
                        if(KValue.Value == "Arrested")
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
            form.Show();
        }

    }
}
