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
            for (int i = 0; i < Suspects.Count; i++ )
            {
                object[] array = Suspects.ElementAt(i).HumanDataToArrayForDataBase();
                array[array.Length - 1] = i;
                Table.Rows.Add(array);
            }
        }
        public static void PutActiveIntoTable(DataGridView Table, KIACollection Suspects)
        {
            for (int i = 0; i < Suspects.Count; i++)
            {
                object[] array = Suspects.ElementAt(i).HumanDataToArrayForDataBase();
                array[array.Length - 1] = i;
                Table.Rows.Add(array);
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
