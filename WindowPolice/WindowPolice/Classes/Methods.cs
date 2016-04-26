using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPolice
{
    class Methods
    {
        public static void PutActiveIntoTable(DataGridView Table, SuspectCollection Suspects)
        {
            foreach (Suspect temp in Suspects)
            {
                Table.Rows.Add(temp.HumanDataToArrayForDataBase());
            }
        }
    }
}
