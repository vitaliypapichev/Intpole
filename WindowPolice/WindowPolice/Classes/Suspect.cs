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
        private HumanPhysData PhysData;
        public int CrimeNumber { get; protected set; }
        public List<string> CrimesList;
        public bool IfWife { get; protected set; }
        public bool IfChildren { get; protected set; }
        public string LastSeen { get; protected set; }
        public string LastCrime { get; protected set; }
        public string Status { get; protected set; }
        public Suspect()
        {
            this.CrimeNumber = 0;
            this.LastCrime = null;
            this.IfWife = false;
            this.IfChildren = false;
            this.LastSeen = null;
            this.CrimesList = new List<string>();
        }
        public Suspect(string Data)
        {
            Char[] a = new Char[] { '~' };
            string[] alldata = Data.Split(a);
            this.PhysData = new HumanPhysData(alldata[0], alldata[1], alldata[2], Methods.CreateDate(alldata[3]), alldata[4], alldata[5], alldata[6], alldata[7], Convert.ToInt32(alldata[8]));
            this.CrimeNumber = Convert.ToInt32(alldata[9]);
            this.LastCrime = alldata[10];
            this.IfWife = Convert.ToBoolean(alldata[11]);
            this.IfChildren = Convert.ToBoolean(alldata[12]);
            this.LastSeen = alldata[13];
            this.CrimesList = CreateList(alldata[14]);
            this.Status = alldata[15];
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
        public void Print()
        {
            System.Console.WriteLine(this.LastCrime);
        }
        static public List<string> CreateList(string Data)
        {
            Char[] Characters = new Char[] { ',', ' ' };
            string[] Strings = Data.Split(Characters);
            List<string> result = new List<string>();
            foreach (string a in Strings)
            {
                result.Add(a);
            }
            return result;
        }
        public override string ToString()
        {
            string temp = string.Join(", ", CrimesList);
            return PhysData.ToString() + "; " + CrimeNumber + "; " + IfWife + "; " + IfChildren + "; " + LastSeen + "; " + LastCrime + "; " + temp + ";";
        }
        public object[] HumanDataToArrayForDataBase()
        {
            object[] result = new object[5];
            object[] copy = PhysData.ToArray();
            for (int i = 0; i < 3; i++)
            {
                result[i] = copy[i];
            }
            result[3] = copy[5];
            result[4] = this.Status;
            return result;
        }
    }
}
