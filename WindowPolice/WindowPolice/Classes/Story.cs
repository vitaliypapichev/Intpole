using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowPolice
{
    public class Story
    {
        public string Place;
        public string State;
        public string Fact;
        public DateTime Date;
        public Point Location;
        public Story(string Data)
        {
            char[] chars = { '>', '=', '#' };
            string[] data = Data.Split(chars);
            this.State = data[0];
            this.Place = data[1];
            this.Fact = data[2];
            this.Date = Methods.CreateDate(data[3]);
            this.Location = new Point();
        }
        public string[] RetrieveData()
        {
            string[] result = new string[3];
            result[0] = this.Place;
            result[1] = this.Fact;
            result[2] = this.Date.ToString("dd/MM/yyyy");
            return result;
        }
        public override string ToString()
        {
            return this.State + '>' + this.Place + '#' + this.Fact + '=' + this.Date.ToString("dd/MM/yyyy");
        }
    }
}
