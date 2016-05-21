using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPolice
{
    public class Story
    {
        public string Place;
        public string State;
        public string Fact;
        public DateTime Date;
        public Story(string Data)
        {
            int a = Data.IndexOf("=>");
            int b = Data.IndexOf('^');
            int c = Data.IndexOf("$#");
            MessageBox.Show(a.ToString());
            MessageBox.Show(b.ToString());
            MessageBox.Show(c.ToString());
        }
    }
}
