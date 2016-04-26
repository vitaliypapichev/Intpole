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
        public Interpole()
        {
            InitializeComponent();
        }
        private void Interpole_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if(login.ShowDialog() != DialogResult.None)
            {
                SuspectCollection Suspects = new SuspectCollection();
                KIACollection KilledInAction = new KIACollection();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void suspectBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow cell = this.SuspectTable.Rows[e.RowIndex];
            for(int i = 0; i < cell.Cells.Count; i++)
            {

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
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
