using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class VillogoGomb : Button
    {
        Color ered;
        public VillogoGomb() //konstruktor neve egyezik az osztály nevével ctor tabtab
        {
            MouseEnter += VillogoGomb_MouseEnter;  //MouseEnter += tabtab
            MouseLeave += VillogoGomb_MouseLeave;
            BackColor = ered;
        }

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = ered;
            
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
            Text = (I*J).ToString();
        }
        public int I { get; set; } // prop tabtab

        public int J { get; set; }

    }
}
