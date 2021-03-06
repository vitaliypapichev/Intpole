﻿using System;
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
            foreach (string str in history)
            {
                this.Add(new Story(str));
            }
        }
        public override string ToString()
        {
            string result = "";
            bool dotcomma = false;
            foreach (Story comparer in this)
            {
                if (dotcomma)
                    result += ';';
                result += comparer.ToString();
                dotcomma = true;
            }
            return result;
        }
    }
}
