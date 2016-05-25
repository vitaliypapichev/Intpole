using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowPolice
{
    public partial class Crimes_List : Form
    {
        private Suspect suspected;
        public Crimes_List(Suspect Susp)
        {
            InitializeComponent();
            this.suspected = Susp;
        }

        private void Crimes_List_Load(object sender, EventArgs e)
        {
           foreach(KeyValuePair<Crime,DateTime> sample in suspected.Crimes)
           {
               dataGridView1.Rows.Add(sample.Key.ToString(), sample.Value.ToString("dd/MM/yyyy"));
           }

        }
    }
}
