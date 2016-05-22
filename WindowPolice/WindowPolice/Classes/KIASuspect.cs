using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPolice
{
    public class KIASuspect : Suspect
    {
        public bool KIAStatus;
        public string PlaceOfDeath { get; protected set; }
        public DateTime DayOfDeath { get; protected set; }
        public string ShortStory;
        public KIASuspect()
            : base()
        {
            this.CrimeNumber = 0;
            this.LastCrime = new Crime();
            this.IfWife = false;
            this.IfChildren = false;
            this.LastSeen = null;
            this.Crimes = new Dictionary<Crime, DateTime>();
            this.Status = "KIA";
            this.KIAStatus = true;
        }
        public KIASuspect(string Data) 
        {
            this.KIAStatus = true;
            Char[] a = new Char[] { '~' };
            string[] alldata = Data.Split(a);
            this.PhysData = new HumanPhysData(alldata[0], alldata[1], alldata[2], Methods.CreateDate(alldata[3]), alldata[4], alldata[5], alldata[6], alldata[7], Convert.ToInt32(alldata[8]));
            this.CrimeNumber = Convert.ToInt32(alldata[9]);
            this.LastCrime = Methods.SetCrime(alldata[10], '>');
            this.IfWife = Convert.ToBoolean(alldata[11]);
            this.IfChildren = Convert.ToBoolean(alldata[12]);
            this.LastSeen = alldata[13];
            this.Crimes = CreateDictionary(alldata[14]);
            this.SearchedIn = alldata[15];
            this.Status = alldata[16];
            this.PicLoc = alldata[17];
            this.PlaceOfDeath = alldata[18];
            this.DayOfDeath = Methods.CreateDate(alldata[19]);
            this.ShortStory = alldata[20];
        }
        public void AddPlace(string Place)
        {
            this.PlaceOfDeath = Place;
        }
        public void AddDate(int Day, int Month, int Year)
        {
            this.DayOfDeath = new DateTime(Day, Month, Year);
        }
        public void AddStory(string Story)
        {
            this.ShortStory = Story;
        }
        public override object[] HumanDataToArrayForDataBase()
        {
            return base.HumanDataToArrayForDataBase();
        }
        public new Dictionary<string, string> ReturnData()
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
            Dict.Add("No", this.PhysData.BirthData.Day.ToString() + this.PhysData.BirthData.Month.ToString() + this.PhysData.BirthData.Year.ToString() + this.PhysData.Name[0] + this.PhysData.Surname[0]);
            return Dict;
        }
        protected override Dictionary<Crime, DateTime> CreateDictionary(string param)
        {
            return base.CreateDictionary(param);
        }
    }
}
