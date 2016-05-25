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
        protected Suspect suspected;
        public Map(Suspect Susp)
        {
            InitializeComponent();
            this.suspected = Susp;
            this.Paint += Map_Paint;
        }

        private void Map_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\View\Images\mp" + suspected.SearchedIn + ".png");
        }

        private void Map_Click(object sender, EventArgs e)
        {
            Methods.FillStory(this.PointToClient(Cursor.Position), dataGridView1, suspected.History);
        }
        private void Draw()
        {
            Graphics Graph = this.CreateGraphics();
            Methods.RetrieveCities(suspected.SearchedIn).Draw(Graph, suspected.History);
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Methods.SetPointerCursor(suspected.History, this.PointToClient(Cursor.Position));
        }
    }
}
