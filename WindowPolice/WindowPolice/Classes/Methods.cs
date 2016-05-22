using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace WindowPolice
{
    public class Methods
    {
        public static Cursor SetPointerCursor(StoryCollection Collection, Point Location)
        {
            foreach (Story History in Collection)
            {
                if (Location.X > History.Location.X - 5 && Location.X < History.Location.X + 5 && Location.Y > History.Location.Y - 5 && Location.Y < History.Location.Y + 5)
                {
                    return Cursors.Hand;
                }
            }
            return Cursors.Arrow;
        }
        public static void FillStory(Point Location, DataGridView Table, StoryCollection Collection)
        {
            Table.Rows.Clear();
            foreach(Story History in Collection)
            {
                if(Location.X > History.Location.X - 5 && Location.X < History.Location.X + 5 && Location.Y > History.Location.Y - 5 && Location.Y < History.Location.Y + 5)
                {
                    Table.Rows.Add(History.RetrieveData());
                }
            }
        }
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
            Char[] Characters = new Char[] { '.' };
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
        public static Crime SetCrime(string CrimeType, char ch)
        {
            string CrimeName = CrimeType.Substring(0, CrimeType.IndexOf(ch)).Trim();
            string CrimeSpec = CrimeType.Substring(CrimeType.IndexOf(ch)+1);
            switch(CrimeName.ToLower())
            {
                case "propcrime": return new PropertyCrime(CrimeSpec);
                case "hacking": return new Hacking(CrimeSpec);
                case "lifethreat": return new LifeThreat(CrimeSpec);
                case "hijacking": return new Hijacking(CrimeSpec);
                case "terrorism": return new Terrorism(CrimeSpec);
                case "corrupt": return new Corruption(CrimeSpec);
                case "drugs": return new Drugs(CrimeSpec);
            }
            return new Crime();
        }
        public static Country RetrieveCities(string Data)
        {
            StreamReader filerow = new StreamReader(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\DataBases\"+Data+".ipd");
            string country = filerow.ReadLine();
            Country CountryName = new Country();
            if (country != null)
            {
                while (country != null)
                {
                    CountryName.CreateCities(country);
                    country = filerow.ReadLine();
                }
            }
            return CountryName;
        }
        public static void Find(SuspectCollection Collect, DataGridView Table, string Text)
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
