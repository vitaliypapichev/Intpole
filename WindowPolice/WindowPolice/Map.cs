using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowPolice
{
    public partial class Map : Form
    {
        protected Suspect Susp;
        public Map(Suspect Susp)
        {
            InitializeComponent();
            this.Susp = Susp;
        }

        private void Map_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\mp" + Susp.SearchedIn + ".png");
        }

        private void Map_Activated(object sender, EventArgs e)
        {

        }

        private void Map_Click(object sender, EventArgs e)
        {
            Graphics Graph = this.CreateGraphics();
            Methods.RetrieveCities(Susp.SearchedIn).Draw(Graph);
        }

    }
}
