using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPolice
{
    public class StoryCollection : List<Story>
    {
        public void FillCollection(string Data)
        {
            Char[] characters = { ';' };
            string[] history = Data.Split(characters);
            foreach(string str in history)
            {
                MessageBox.Show(str);
                this.Add(new Story(str));
            }
        }
    }
}
