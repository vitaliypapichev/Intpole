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

namespace WindowPolice
{
    public partial class WorldMap : Form
    {
        private SuspectCollection suspects;
        public WorldMap()
        {
            InitializeComponent();
            suspects = new SuspectCollection();
        }

        private void WorldMap_Load(object sender, EventArgs e)
        {
            suspects.FillSuspectCollection();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadInterpoleForm("USA");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Images\europ.png");
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            loadInterpoleForm("Ukraine");
        }
        private void loadInterpoleForm(string Country)
        {
            SuspectCollection ToLoad = new SuspectCollection();
            foreach (Suspect suspected in suspects)
            {
                if (suspected.SearchedIn.Equals(Country))
                    ToLoad.Add(suspected);
            }
            Interpole SuspectForm = new Interpole(ToLoad, suspects, Country);
            this.Visible = false;
            if (SuspectForm.ShowDialog() != DialogResult.None)
            {
                this.Visible = true;
            }
        }

        private void WorldMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream file = new FileStream(@"DataBases\suspects.ipd", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            foreach (Suspect Susp in suspects)
            {
                writer.WriteLine(Susp.ToString());
            }
            writer.Close();
            file.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Images\world-map-large.png");
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }
    }
}
