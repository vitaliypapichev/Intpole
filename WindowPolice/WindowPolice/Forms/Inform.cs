﻿using System;
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
    public partial class Inform : Form
    {
        private Suspect suspected;
        public Inform(Suspect Susp)
        {
            InitializeComponent();
            this.suspected = Susp;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Crimes_List CrimesList = new Crimes_List(suspected);
            CrimesList.Location = new Point(this.Location.X + 30, this.Location.Y + this.Height - CrimesList.Height - 30);
            if(CrimesList.ShowDialog() != DialogResult.None)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Map Map = new Map(suspected);
            if(Map.ShowDialog() != DialogResult.None)
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditingForm Editor = new EditingForm(suspected);
            if(Editor.ShowDialog() != DialogResult.None)
            {
                this.Close();
            }
        }
    }
}
