using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowPolice
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void private_validation()
        {
            string name = this.textBox1.Text;
            string pass = this.textBox2.Text;
            string temporaryname = "";
            string temporarypassword = "";
            StreamReader fs = new StreamReader(@"D:\OOp\Kursovaya\Interpolice\Intpole\WindowPolice\WindowPolice\DataBases\staff.ipd");
            string comparer = fs.ReadLine();
            while(true)
            {
                if (comparer == null) break;
                int p = comparer.IndexOf(':');
                temporaryname = comparer.Substring(0, p);
                temporarypassword = comparer.Substring(p+1, (comparer.Length-p)-1);
                if (temporaryname == name && temporarypassword == pass)
                {
                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                    Thread.Sleep(2000);
                    this.Visible = false;
                    return;
                }
                comparer = fs.ReadLine();
            }
           this.Validity1.SetIconPadding(this.textBox1, 6);
           this.Validity1.SetError(this.textBox1, "Access denied. Check validity of typed data or try again");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            private_validation();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                private_validation();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                private_validation();
            }
            if (e.KeyCode == Keys.Delete)
            {
                this.Validity1.Clear();
            }
            if (e.KeyCode == Keys.Back)
            {
                this.Validity1.Clear();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                private_validation();
            }
            if (e.KeyCode == Keys.Delete)
            {
                this.Validity1.Clear();
            }
            if (e.KeyCode == Keys.Back)
            {
                this.Validity1.Clear();
            }
        }
    }
}
