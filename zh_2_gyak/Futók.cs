﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh_2_gyak
{
    public class Futók //átírni public-ra
    {
        //VersenyzoID,Nev,Nemzetiseg,EredmenyPerc,Kategoria
        public int VersenyzoID { get; set; }

        public string Nev { get; set; } = string.Empty;
        public string Nemzetiseg { get; set; } = string.Empty;
        public double EredmenyPerc { get; set; }
        public string Kategoria { get; set; } = string.Empty;
    }
}
