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
            Table.Rows.Clear();
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
            if(CrimeName.ToLower().Equals("corruption"))
            {
                return new Corruption(CrimeSpec);
            }
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
            StreamReader filerow = new StreamReader(@"DataBases\"+Data+".ipd");
            filerow.ReadLine();
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
        public static void FindRegions(string County, ComboBox Combob)
        {
            Combob.Items.Clear();
            StreamReader filerow = new StreamReader(@"DataBases\"+County+".ipd");
            Char[] characters = { ';' };
            string[] result = filerow.ReadLine().Split(characters);
            for (int i = 0; i < result.Length; i++)
            {
                Combob.Items.Add(result[i]);
            }
            Combob.Text = Combob.Items[0].ToString();
        }
        public static void FindInFileCrime(string Crime, ComboBox Combob)
        {
            StreamReader filerow = new StreamReader(@"DataBases\crimes.ipd");
            Char[] characters = { ';' };
            string result = filerow.ReadLine();
            string[] query;
            if (result.Split(characters)[0].Equals(Crime))
            {
                query = result.Substring(result.IndexOf(';')+1).Split(characters);
                for (int i = 0; i < query.Length; i++)
                {
                    Combob.Items.Add(query[i]);
                }
                Combob.Text = Combob.Items[0].ToString();
                return;
            }
            while (!result.Split(characters)[0].Equals(Crime))
            {
                result = filerow.ReadLine();
            }
            query = result.Substring(result.IndexOf(';') + 1).Split(characters);
            for (int i = 0; i < query.Length; i++)
            {
                Combob.Items.Add(query[i]);
            }
            Combob.Text = Combob.Items[0].ToString();
        }
        public static bool ifCheck(params TextBox[] boxes)
        {
            foreach (TextBox Box in boxes)
            {
                if (Box.Text.IndexOf('#') != -1 || Box.Text.IndexOf('~') != -1 || Box.Text.IndexOf('=') != -1 || Box.Text.IndexOf(':') != -1 || Box.Text.IndexOf('>') != -1)
                {
                    Box.BackColor = Color.FromArgb(255, 128, 128);
                    return true;
                }
            }
            return false;
        }
    }
}
