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
        public void Draw(Graphics Graphic)
        {
            GraphicsPath Path = new GraphicsPath();
            Path.AddEllipse(Cities.ElementAt(0).Value.X-5, Cities.ElementAt(0).Value.Y-5, 10, 10);
            for(int i = 1; i < Cities.Count; i++)
            {
                Path.AddLine(Cities.ElementAt(i - 1).Value, Cities.ElementAt(i).Value);
                Path.AddEllipse(Cities.ElementAt(i).Value.X - 5, Cities.ElementAt(i).Value.Y-5, 10, 10);
            }
            Graphic.DrawPath(new Pen(Color.Black, 2), Path);
            for (int i = 0; i < Cities.Count; i++)
            {
                SolidBrush kek = new SolidBrush(Color.Blue);
                Graphic.FillEllipse(kek, Cities.ElementAt(i).Value.X-5, Cities.ElementAt(i).Value.Y-5, 10, 10);
            }
        }
    }
}
