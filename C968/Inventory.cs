using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968
{
    public class Inventory
    {
        public BindingList<Product> Products = new BindingList<Product>();
        public BindingList<Part> AllParts = new BindingList<Part>();
        public void addPart(Product prod)
        {
        }
        public bool removePart(Part part) {
            return true;
        }
        public Product lookupProduct(int ID)
        {
            return new Product(); 
        }
        public void updateProduct(int num, Product product)
        {
        }
        public void AddPart(Part part)
        {

        }
        public bool deletePart(Part part)
        {
            return true;
        }
        public Part lookupPart(int ID)
        {
            return new Part();
        }
        public void updatePart(int num, Part part)
        {
        }
    }
}
