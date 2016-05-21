using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowPolice
{
    public class SuspectCollection : List<Suspect>
    {
        public void FillSuspectCollection()
        {
            StreamReader filerow = new StreamReader(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\DataBases\suspects.ipd");
            string suspect = filerow.ReadLine();
            if (suspect != null)
            {
                while (suspect != null)
                {
                    this.Add(new Suspect(suspect));
                    suspect = filerow.ReadLine();
                }
            }
        }
       
    }
}
