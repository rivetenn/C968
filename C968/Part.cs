using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Part
    {
        public static int AID = 1;
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal PartPrice { get; set; }
        public int PartinStock { get; set; }
        public int PartMin { get; set; }
        public int PartMax { get; set; }

        public Part(string name, decimal price, int inStock, int min, int max)
        {
            PartID = AID;
            PartName = name;
            PartPrice = price;
            PartinStock = inStock;
            PartMin = min;
            PartMax = max;
            AID++;
        }
    }
}

