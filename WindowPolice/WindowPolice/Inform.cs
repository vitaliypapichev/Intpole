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
    public partial class Inform : Form
    {
        private Suspect Susp;
        public Inform(Suspect Susp)
        {
            InitializeComponent();
            this.Susp = Susp;
        }

        private void Inform_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crimes_List CrimesList = new Crimes_List(Susp);
            CrimesList.Location = new Point(this.Location.X + 30, this.Location.Y + this.Height - CrimesList.Height - 30);
            if(CrimesList.ShowDialog() != DialogResult.None)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Map Map = new Map(Susp);
            if(Map.ShowDialog() != DialogResult.None)
            {

            }
        }
    }
}
