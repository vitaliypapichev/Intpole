﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowPolice
{
    public class Crime
    {
        protected string specialization;
        public Crime(string CrimeName)
        {
            specialization = CrimeName;
        }
        public Crime()
        {
            specialization = "Undefined crime";
        }
        public override string ToString()
        {
            return this.GetType().Name + ">" + this.specialization;
        }
        public virtual string GetTypeName()
        {
            return this.GetType().Name;
        }
        public virtual bool Equals(Crime Another)
        {
            return this.specialization.ToLower().Equals(Another.specialization.ToLower());
        }
    }
    public class PropertyCrime : Crime
    {
        public PropertyCrime()
            : base()
        { }
        public PropertyCrime(string CrimeName)
            : base(CrimeName)
        { }
        public override string ToString()
        {
            return "PropCrime>" + this.specialization;
        }
        public override string GetTypeName()
        {
            return base.GetTypeName();
        }
        public override bool Equals(Crime Another)
        {
            return base.Equals(Another);
        }
    }
    public class LifeThreat : Crime
    {
        public LifeThreat()
            : base()
        { }
        public LifeThreat(string CrimeName)
            : base(CrimeName)
        { }
        public override string ToString()
        {
            return "LifeThreat>" + this.specialization;
        }
        public override string GetTypeName()
        {
            return base.GetTypeName();
        }
        public override bool Equals(Crime Another)
        {
            return base.Equals(Another);
        }
    }
    public class Hacking : Crime
    {
        public Hacking()
            : base()
        { }
        public Hacking(string CrimeName)
            : base(CrimeName)
        { }
        public override string ToString()
        {
            return "Hacking>" + this.specialization;
        }
        public override string GetTypeName()
        {
            return base.GetTypeName();
        }
        public override bool Equals(Crime Another)
        {
            return base.Equals(Another);
        }
    }
    public class Terrorism : Crime
    {
        public Terrorism()
            : base()
        { }
        public Terrorism(string CrimeName)
            : base(CrimeName)
        { }
        public override string ToString()
        {
            return "Terrorism>" + this.specialization;
        }
        public override string GetTypeName()
        {
            return base.GetTypeName();
        }
        public override bool Equals(Crime Another)
        {
            return base.Equals(Another);
        }
    }
    public class Hijacking : Crime
    {
        protected string gravofoff;
        public Hijacking()
            : base()
        {
            this.gravofoff = "Small Gravity";
        }
        public Hijacking(string CrimeName)
            : base(CrimeName)
        {
            this.specialization = CrimeName;
            switch(CrimeName)
            {
                case "Plane Hj.": this.gravofoff = "High Gravity"; break;
                case "Ship Hj.": this.gravofoff = "High Gravity"; break;
                case "Train Hj.": this.gravofoff = "High Gravity"; break;
                case "SlTransp Hj.": this.gravofoff = "High Gravity"; break;
                case "Mtbike Hj.": this.gravofoff = "Medium Gravity"; break;
                case "Car Hj.": this.gravofoff = "Medium Gravity"; break;
                case "Bycicle Hj.": this.gravofoff = "Small Gravity"; break;
                case "Skate Hj.": this.gravofoff = "Small Gravity"; break;
            }
        }
        public override string ToString()
        {
            return "Hijacking>" + this.specialization;
        }
        public override string GetTypeName()
        {
            return base.GetTypeName();
        }
        public override bool Equals(Crime Another)
        {
            return base.Equals(Another);
        }
    }
    public class Corruption : Crime
    {
        public Corruption()
            : base()
        { }
        public Corruption(string CrimeName)
            : base(CrimeName)
        { }
        public override string ToString()
        {
            return "Corruption>" + this.specialization;
        }
        public override string GetTypeName()
        {
            return base.GetTypeName();
        }
        public override bool Equals(Crime Another)
        {
            return base.Equals(Another);
        }
    }
    public class Drugs : Crime
    {
        public Drugs()
            : base()
        { }
        public Drugs(string CrimeName)
            : base(CrimeName)
        { }
        public override string ToString()
        {
            return "Drugs>" + this.specialization;
        }
        public override string GetTypeName()
        {
            return base.GetTypeName();
        }
        public override bool Equals(Crime Another)
        {
            return base.Equals(Another);
        }
    }
}
