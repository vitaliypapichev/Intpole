using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowPolice
{
    class Methods
    {
        public static void PutActiveIntoTable(DataGridView Table, SuspectCollection Suspects)
        {
            for (int i = 0; i < Suspects.Count; i++)
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
        static public void SetFlag(string country, PictureBox box)
        {
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
        static public string CrimesToString(List<string> Crimes)
        {
            string result = "";
            bool count = false;
            foreach(string str in Crimes)
            {
                if (str == " " || str == "")
                    continue;
                if (count)
                    result += ", " + str;
                else
                {
                    result += str;
                    count = true;
                }
            }
            return result;
        }
    }
}
