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
                FileStream file = new FileStream(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\DataBases\suspects.ipd", FileMode.Open);
                StreamReader filerow = new StreamReader(file);
                string suspect = filerow.ReadLine();
                if (suspect != null)
                {
                    while (suspect != null)
                    {
                        this.Add(new Suspect(suspect));
                        suspect = filerow.ReadLine();
                    }
                }
                filerow.Close();
                file.Close();
        }
        
    }
}
