using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowPolice
{
    public class KIACollection : SuspectCollection
    {
        public new void FillSuspectCollection()
        {
                StreamReader filerow = new StreamReader(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\DataBases\kia.ipd");
                string suspect = filerow.ReadLine();
                if (suspect != null)
                {
                    while (suspect != null)
                    {
                        this.Add(new KIASuspect(suspect));
                        suspect = filerow.ReadLine();
                    }
                }
            }
        }
    }
