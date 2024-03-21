using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KígyósJáték
{
    internal class KígyóElem : PictureBox
    {
        public static int méret = 20;
        //public static int hossz = 1;
        public KígyóElem()
        {
            Width = KígyóElem.méret;
            Height = KígyóElem.méret;
            BackColor = Color.Fuchsia;
        }
    }
}
