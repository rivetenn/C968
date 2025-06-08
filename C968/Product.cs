using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Product
    {

        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        int ProductID { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int InStock { get; set; }
        int Min { get; set; }
        int Max { get; set; }

        public void addAssociatedPart(Part part)
        {

        }

        public bool removeAssociatedPart(int ID)
        {
            return true;
        }

        //public Part lookupAssociatedPart(int ID)
        //{
        //    return;
        //}
    }
}
