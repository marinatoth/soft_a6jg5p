﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatKotes
{
    public class CountryData // pubic internal helyett
    {
        //Name,Population,AreaInSquareKm
        public string Name { get; set; } = string.Empty;
        public long Population { get; set; }
        public double AreaInSquareKm { get; set; }
    }
}
