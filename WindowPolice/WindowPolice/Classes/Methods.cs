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
        public static void PutActiveIntoTable(DataGridView Table, KIACollection Suspects)
        {
            foreach (Suspect temp in Suspects)
            {
                Table.Rows.Add(temp.HumanDataToArrayForDataBase());
            }
        }
        static public DateTime CreateDate(string Date)
        {
            Char[] Characters = new Char[] { ',' };
            string[] Strings = Date.Split(Characters);
            Console.WriteLine(new DateTime(Convert.ToInt32(Strings[2]), Convert.ToInt32(Strings[1]), Convert.ToInt32(Strings[0])));
            return new DateTime(Convert.ToInt32(Strings[2]), Convert.ToInt32(Strings[1]), Convert.ToInt32(Strings[0]));
        }
    }
}
