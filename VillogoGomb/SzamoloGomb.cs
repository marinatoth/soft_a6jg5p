using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzamoloGomb : Button
    {
        public SzamoloGomb() //konstruktor ctor tabtab
        {
            Height = 20;
            Width = 20;
            MouseClick += SzamoloGomb_MouseClick;   //MouseClick += tabtab
            Szam = 1;
            Text = Szam.ToString();
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            Szam++;
            if (Szam >5) { Szam = 1; }
            Text = (Szam).ToString();
        }

        public int Szam { get; set; }
    }
}
