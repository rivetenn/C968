using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    internal class Outsourced : Part
    {
        public string PartCN { get; set; }

        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string notMID)
        : base(partID, name, price, inStock, min, max)
        {
            PartCN = notMID;
        }
    }
}
