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
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static void AddProd(Product prod)
        {
            Products.Add(prod);
        }
        static public bool removeProduct(Product prod) {
            if (YesNoV())
            {
                return Products.Remove(prod);
            }
            else return false;
        }
        public static Product lookupProduct(int ID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == ID)
                    return prod;
            }
            return null;
        }
        public static void updateProduct(int num, Product product)
        {
            Products[num] = product;
        }
        public void AddPart(Part part)
        {
            if (part is Outsourced outsourced)
            {
                AllParts.Add(outsourced); 
            }
            else if (part is Inhouse inhouse)
            {
                AllParts.Add(inhouse); 
            }
        }

        public static bool deletePart(Part part)
        {
            if(YesNoV()){
                foreach (Product product in Products)
                {
                    if (product.lookupAssociatedPart(part.PartID) != null)
                    {
                        MessageBox.Show("Cannot delete part, it is associated with a product.");
                        return false;
                    }
                }

                return AllParts.Remove(part);
            }
            else return false;
        }
        public static Part lookupPart(int ID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == ID)
                    return part;
            }
            return null;
        }

        public static void updatePart(int num, Part part)
        {
            AllParts[num] = part;
        }

        public static bool YesNoV()
        {
            return MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public static void IncorNum()
        {
            MessageBox.Show("Inventory amount is invalid");
            return;
        }

    }
}
