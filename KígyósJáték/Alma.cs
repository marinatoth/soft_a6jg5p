using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KígyósJáték
{
    internal class Alma : PictureBox
    {
        public static int méret = 20;
        public Alma()
        {          
            BackColor = Color.Red;
            Height = Alma.méret;
            Width = Alma.méret;
            
        }

        //public bool Eheto { get; set; }
    }
}
