using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowPolice
{
    public class HumanPhysData
    {
        public string Name {get; private set;}
        public string Surname { get; private set; }
        public string Patronymic { get; private set; }
        public DateTime BirthData { get; private set; }
        public string BirthPlace { get; private set; }
        public int Years { get; private set; }
        public string Build { get; private set; }
        public string Hair { get; private set; }
        public string Eyes { get; private set; }
        public int Height { get; private set; }
        public HumanPhysData(string Name, string Surname, string Patronymic, DateTime BirthData, string BirthPlace, string Build, string Hair, string Eyes, int Height)
        {
            this.BirthPlace = BirthPlace;
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.BirthData = BirthData;
            this.Years = (BirthData.DayOfYear - DateTime.Now.DayOfYear) >= 0 ? DateTime.Now.Year - BirthData.Year - 1 : DateTime.Now.Year - BirthData.Year;
            this.Build = Build;
            this.Hair = Hair;
            this.Eyes = Eyes;
            this.Height = Height;
        }
        public override string ToString()
        {
            return Name + "~" + Surname + "~" + Patronymic + "~" + BirthData.Date.ToString("dd/MM/yyyy") + "~" + BirthPlace + "~" + Build + "~" + Hair + "~" + Eyes + "~" + Height;
        }
        public object[] ToArray()
        {
            object[] obj = new object[10];
            obj[0] =  this.Name;
            obj[1] =  this.Surname;
            obj[2] =  this.Patronymic;
            obj[3] =  this.BirthData.ToString("dd/MM/yyyy");
            obj[4] =  this.BirthPlace;
            obj[5] =  this.Years;
            obj[6] =  this.Build;
            obj[7] =  this.Eyes;
            obj[8] =  this.Hair;
            obj[9] =  this.Height;
            return obj;
        }
    }
}
