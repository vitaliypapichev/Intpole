using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowPolice.Classes
{
    public class Suspect
    {
        //private HumanPhysData PhysData;
        public int CrimeNumber { get; private set; }
        public List<string> CrimesList;
        public bool IfWife { get; private set; }
        public bool IfChildren { get; private set; }
        public string LastSeen { get; private set; }
        public string LastCrime { get; private set; }
        public Suspect(string LastCrime)
        {
            //this.PhysData = PhysData;
            this.CrimeNumber = 1;
            this.LastCrime = LastCrime;
            this.IfWife = false;
            this.IfChildren = false;
            this.LastSeen = null;
            this.CrimesList = new List<string>();
            this.CrimesList.Add(LastCrime);
        }
        public void AddCrime(string Crime, string PlaceOfCrime)
        {
            this.LastSeen = PlaceOfCrime;
            this.CrimesList.Add(Crime);
            this.LastCrime = Crime;
            CrimeNumber++;
        }
        public void AddCrime(string Crime)
        {
            this.CrimesList.Add(Crime);
            this.LastCrime = Crime;
            CrimeNumber++;
        }
        public void WasSeen(string PlaceName)
        {
            this.LastSeen = PlaceName;
        }
        public void HasWife(bool HasHe)
        {
            this.IfWife = HasHe;
        }
        public void HasChildren(bool HasHe)
        {
            this.IfChildren = HasHe;
        }
        public void Show()
        {
            Console.Write(CrimeNumber.ToString() + " " + IfWife.ToString() + " " + IfChildren.ToString() + ", ");
        }
    }
}
