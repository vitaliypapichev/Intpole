using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowPolice.Classes
{
    class SuspectCollection : List<Suspect>
    {
        public void Print()
        {
            foreach (Suspect abc in this)
            {
                abc.Show();
            }
        }
    }
}
