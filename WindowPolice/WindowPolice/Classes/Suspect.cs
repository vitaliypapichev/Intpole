using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPolice
{
    delegate DateTime GetDate(string type);

    public class Suspect
    {
        protected HumanPhysData PhysData;
        public int CrimeNumber { get; protected set; }
        public Dictionary<Crime, DateTime> Crimes;
        public bool IfWife { get; set; }
        public bool IfChildren { get; set; }
        public string LastSeen { get; protected set; }
        public Crime LastCrime { get; protected set; }
        public string Status { get; set; }
        public string PicLoc;
        public string SearchedIn;
        public StoryCollection History;
        public Suspect()
        {
            this.CrimeNumber = 0;
            this.LastCrime = null;
            this.IfWife = false;
            this.IfChildren = false;
            this.LastSeen = null;
            this.Crimes = new Dictionary<Crime, DateTime>();
            this.SearchedIn = null;
            History = new StoryCollection();
        }
        public Suspect(string Data)
        {
            History = new StoryCollection();
            Char[] a = new Char[] { '~' };
            string[] alldata = Data.Split(a);
            this.PhysData = new HumanPhysData(alldata[0], alldata[1], alldata[2], Methods.CreateDate(alldata[3]), alldata[4], alldata[5], alldata[6], alldata[7], Convert.ToInt32(alldata[8]));
            this.CrimeNumber = Convert.ToInt32(alldata[9]);
            this.LastCrime = Methods.SetCrime(alldata[10],'>');
            this.IfWife = Convert.ToBoolean(alldata[11]);
            this.IfChildren = Convert.ToBoolean(alldata[12]);
            this.LastSeen = alldata[13];
            this.Crimes = CreateDictionary(alldata[14]);
            this.SearchedIn = alldata[15];
            this.Status = alldata[16];
            this.PicLoc = alldata[17];
            History.FillCollection(alldata[18]);
        }
        public override string ToString()
        {
            return PhysData.ToString() + "~" + this.CrimeNumber.ToString() + "~" + this.LastCrime.ToString() + "~" + IfWife.ToString() + "~" + IfChildren.ToString() + "~" + this.LastSeen + "~" + CrimeString() +"~" + this.SearchedIn + "~" + this.Status + "~" + this.PicLoc + "~" + History.ToString();
        }
        public virtual object[] HumanDataToArrayForDataBase()
        {
            object[] result = new object[6];
            object[] copy = PhysData.ToArray();
            for (int i = 0; i < 3; i++)
            {
                result[i] = copy[i];
            }
            result[3] = copy[5];
            result[4] = this.Status;
            result[5] = 0;
            return result;
        }
        private string CrimeString()
        {
            string result = "";
            bool dotcomma = false;
            foreach(KeyValuePair<Crime,DateTime> comparer in Crimes)
            {
                if (dotcomma)
                    result += ", ";
                result+=comparer.Key.ToString() + ':' + comparer.Value.ToString("dd/MM/yyyy");
                dotcomma = true;
            }
            return result;
        }
        public Dictionary<string, string> ReturnData()
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();
            Dict.Add("Name", this.PhysData.Name);
            Dict.Add("Surname", this.PhysData.Surname);
            Dict.Add("Patronymic", this.PhysData.Patronymic);
            Dict.Add("Date of birth", this.PhysData.BirthData.ToString("d"));
            Dict.Add("Place of birth", this.PhysData.BirthPlace);
            Dict.Add("Years", this.PhysData.Years.ToString());
            Dict.Add("Build", this.PhysData.Build);
            Dict.Add("Eyes", this.PhysData.Eyes);
            Dict.Add("Hair", this.PhysData.Hair);
            Dict.Add("Height", (this.PhysData.Height.ToString() + " cm"));
            Dict.Add("Number of crimes", this.CrimeNumber.ToString());
            Dict.Add("List of crimes", this.Crimes.ToString());
            Dict.Add("Last commited crime", this.LastCrime.ToString());
            Dict.Add("Was last seen", this.LastSeen);
            Dict.Add("Has wife", this.IfWife.ToString());
            Dict.Add("Has children", this.IfChildren.ToString());
            Dict.Add("Status", this.Status);
            Dict.Add("Photo", this.PicLoc);
            Dict.Add("SearchedIn", this.SearchedIn);
            Dict.Add("No", this.PhysData.BirthData.Day.ToString() + this.PhysData.BirthData.Month.ToString() + this.PhysData.BirthData.Year.ToString() + this.PhysData.Name[0].ToString().ToUpper() + this.PhysData.Surname[0].ToString().ToUpper());
            return Dict;
        }
        protected virtual Dictionary<Crime, DateTime> CreateDictionary(string param)
        {
            Dictionary<Crime, DateTime> result = new Dictionary<Crime, DateTime>();
            Char[] Characters = new Char[] { ',' };
            string[] a = param.Split(Characters);
            for(int i = 0 ; i < a.Length; i++)
            {
                result.Add(Methods.SetCrime(a[i].Substring(0, a[i].IndexOf(':')), '>'), Methods.CreateDate(a[i].Substring(a[i].IndexOf(':') + 1)));
            }
            return result;
        }
        public bool MatchesQuery(string[] Data)
        {
            int counter = 0;
            Dictionary<string, string> dictio = this.ReturnData();
            for (int i = 0; i < Data.Length; i++)
            {
                foreach (KeyValuePair<string, string> comparer in dictio)
                {
                    if (Data[i].Substring(0, Data[i].IndexOf(':')).ToLower().Equals(comparer.Key.ToLower()))
                    {
                        if (Data[i].Substring(Data[i].IndexOf(':') + 1).ToLower().Equals(comparer.Value.ToLower()))
                            counter++;
                    }
                }
                foreach (KeyValuePair<Crime, DateTime> comparer in Crimes)
                {
                    if (comparer.Key.GetType().Name.ToLower().Equals(ReplaceStr(Data[i].ToLower().Substring(0,Data[i].IndexOf(':')))) && comparer.Key.Equals(Methods.SetCrime(Data[i].ToLower(), ':')))
                    {
                        counter++;
                    }
                }
            }
            if(counter == Data.Length)
            {
                return true;
            }
            return false;
        }
        private string ReplaceStr(string Data)
        {
            switch (Data)
            {
                case "name": return "Name";
                case "sname": return "Surname";
                case "namepatro": return "Patronymic";
                case "birth": return "Date of birth";
                case "bplace": return "Place of birth";
                case "crimenum": return "Number of crimes";
                case "lastcrime": return "Last commited crime";
                case "wasseen": return "Was last seen";
                case "haswife": return "Has wife";
                case "propcrime": return "PropertyCrime";
                case "hack": return "Hacking";
                case "hijack": return "Hijacking";
                case "corrupt": return "Corruption";
                case "terror": return "Terrorism";
            }
            return Data;
        }
    }
}
