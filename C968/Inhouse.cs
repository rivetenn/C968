﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Inhouse : Part
    {
        public int PartMID { get; set; }

        public Inhouse(string name, decimal price, int inStock, int min, int max, int MID)
        : base(name, price, inStock, min, max) {
            PartMID = MID;
        }
    }
}
