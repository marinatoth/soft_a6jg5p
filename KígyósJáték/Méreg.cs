using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KígyósJáték
{
    internal class Méreg : PictureBox
    {
        public static int méret = 20;
        public Méreg()
        {
            BackColor = Color.Black;
            Height = Méreg.méret;
            Width = Méreg.méret;

        
    }
    }
}
