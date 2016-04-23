using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowPolice.Classes
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
        public double Height { get; private set; }
        public HumanPhysData(string Name, string Surname, string Patronymic, DateTime BirthData, int Years, string BirthPlace, string Build, string Hair, string Eyes, double Height)
        {
            this.BirthPlace = BirthPlace;
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.BirthData = BirthData;
            this.Years = Years;
            this.Build = Build;
            this.Hair = Hair;
            this.Eyes = Eyes;
            this.Height = Height;
        }
    }
}
