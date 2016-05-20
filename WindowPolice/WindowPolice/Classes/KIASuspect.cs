using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.LastCrime = null;
            this.IfWife = false;
            this.IfChildren = false;
            this.LastSeen = null;
            this.Crimes = new Dictionary<Crime, DateTime>();
            this.Status = "KIA";
            this.KIAStatus = true;
        }
        public KIASuspect(string Data) 
            : base(Data)
        {
            this.KIAStatus = true;
            Char[] a = new Char[] { '~' };
            string[] alldata = Data.Split(a);
            this.PlaceOfDeath = alldata[16];
            this.DayOfDeath = Methods.CreateDate(alldata[17]);
            this.ShortStory = alldata[18];
            this.PicLoc = alldata[19];
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
    }
}
