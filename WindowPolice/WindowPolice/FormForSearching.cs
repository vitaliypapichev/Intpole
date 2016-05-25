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
            Find(collection, table, textBox1.Text);
        }
        private void Find(SuspectCollection Collect, DataGridView Table, string Text)
        {
            Char[] splitters = { ';' };
            string[] findparams = Text.Split(splitters);
            Table.Rows.Clear();
            for (int i = 0; i < Collect.Count; i++)
            {
                if (Collect.ElementAt(i).MatchesQuery(findparams))
                {
                    object[] array = Collect.ElementAt(i).HumanDataToArrayForDataBase();
                    array[array.Length - 1] = i;
                    Table.Rows.Add(array);
                }
            }
        }
    }
}
