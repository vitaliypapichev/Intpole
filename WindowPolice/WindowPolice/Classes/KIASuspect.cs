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
            this.CrimesList = new List<string>();
            this.KIAStatus = true;
        }
        public KIASuspect(string Data)
            : base(Data)
        {
            this.KIAStatus = true;
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
    }
}
