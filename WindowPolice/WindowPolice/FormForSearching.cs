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
    public partial class FormForSearching : Form
    {
        private SuspectCollection collection;
        private DataGridView table;
        public FormForSearching(SuspectCollection Collect, DataGridView Table)
        {
            InitializeComponent();
            this.collection = Collect;
            this.table = Table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Methods.Find(collection, table, textBox1.Text);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (SuspectRadio.Checked)
            {
                textBox1.Enabled = true;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.BackColor = Color.LightGray;

            }
        }
        private void GroupRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (GroupRadio.Checked) 
            {
                textBox2.Enabled = true;
                textBox2.BackColor = Color.White;
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.BackColor = Color.LightGray;
            }
        }

    }
}
