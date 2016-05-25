using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowPolice
{
    public class Country
    {
        public Dictionary<string, Point> Cities;
        public string Name { get; private set; }
        public Country()
        {
            Cities = new Dictionary<string, Point>();
        }
        public void CreateCities(string Data)
        {
           Cities.Add(Data.Substring(0, Data.IndexOf(':')), CreatePoint(Data.Substring(Data.IndexOf(':') + 1)));
        }
        private Point CreatePoint(string Data)
        {
            return new Point(Convert.ToInt32(Data.Substring(0, Data.IndexOf(';'))), Convert.ToInt32(Data.Substring(Data.IndexOf(';') + 1)));
        }
        public void Draw(Graphics Graphic, StoryCollection Collection)
        {
            GraphicsPath Path = new GraphicsPath();
            SolidBrush brush = new SolidBrush(Color.Blue);
            Point pos1 = new Point();
            Point pos2 = new Point();
            bool todelete = false;
            if(Collection.Count == 1)
            {
                Collection.Add(Collection.ElementAt(0));
                todelete = true;
            }
            for (int i = 0; i < Collection.Count - 1; i++ )
            {
                pos1 = new Point();
                pos2 = new Point();
                bool breaker = false;
                foreach(KeyValuePair<string, Point> comparer in Cities)
                {
                    if(Collection.ElementAt(i).State == comparer.Key)
                    {
                        pos1 = comparer.Value;
                        Collection.ElementAt(i).Location = comparer.Value;
                    }
                    if (Collection.ElementAt(i + 1).State == comparer.Key)
                    {
                        pos2 = comparer.Value;
                    }    
                    if (Collection.ElementAt(i).State == comparer.Key && Collection.ElementAt(i + 1).State == comparer.Key)
                    {
                        breaker = true;
                        break;
                    }            
                }
                if (breaker)
                    continue;
                Path.AddLine(pos1, pos2);
                Path.AddEllipse(pos1.X - 5, pos1.Y - 5, 10, 10);
                Graphic.FillEllipse(brush, pos1.X - 5, pos1.Y - 5, 10, 10);
            }
            Collection.ElementAt(Collection.Count-1).Location = pos2;
            Path.AddEllipse(pos2.X - 5, pos2.Y - 5, 10, 10);
            Graphic.FillEllipse(brush, pos2.X - 5, pos2.Y - 5, 10, 10);
            Graphic.DrawPath(new Pen(Color.Black, 2), Path);
            Collection.Remove(Collection.ElementAt(Collection.Count - 1));
        }
    }
}
