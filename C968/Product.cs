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
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product (int prod, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = prod;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int ID)
        {
            if (Inventory.YesNoV())
            {
                var part = lookupAssociatedPart(ID);
                if (part != null)
                {
                    return AssociatedParts.Remove(part);
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int ID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == ID)
                    return part;
            }
            return null;
        }
    }
}
