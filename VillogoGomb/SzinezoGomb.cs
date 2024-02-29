using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzinezoGomb : Button
    {
        public SzinezoGomb() //konstruktor ctor tabtab
        {
            Width = 20;
            Height = 20;
            MouseClick += SzinezoGomb_MouseClick; //MouseClick += tabtab
        }

        private void SzinezoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;

        }
    }
}
