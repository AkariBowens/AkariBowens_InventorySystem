using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    internal class Product
    {

        // Attributes 

        // use if changing data visualization
        // private BindingList<Part> _parts;
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        // private BindingList<Part> Parts = new BindingList<Part>();
        // public static BindingList<Part> Parts { get { return AssociatedParts; } }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int inStock { get; set; }
        public int Min { get; set; }
        public int Max {get; set; } 

        public Product(int productIDNum, string productName, int numInStock, double productPrice, int Minimum, int Maximum)
        {
            // ID is auto created and incremental
            // int productIDNum = 
            ProductID = productIDNum;
            Name = productName;
            inStock = numInStock;
            Price = (decimal)productPrice;
            Min = Minimum;
            Max = Maximum;
            
            Console.WriteLine("Storing new product called " + productName + ".\n");
        }

        //static Product EmptyProduct()
        //{

        //}

        // -----Methods----- //
        public void addAssociatedPart(Part newPart) 
        {
            //adds part to product
            Inventory.TempProduct.AssociatedParts.Add(newPart);
        }
        
        public bool removeAssociatedPart(int partIDNum) 
        {
            if (Inventory.TempProduct.AssociatedParts.Remove(Inventory.TempProduct.AssociatedParts[partIDNum]))
            {
                return true;
            } else {
                return false;
            }
        }
        public static Part lookupAssociatedPart(int partIDNum)
        {
            Part foundPart = Inventory.AllParts[partIDNum];
            Console.Write("Found " + foundPart);
            return foundPart;
        }

        // public BindingList<Part> returnList(Product selectedProduct)
        // {
            // return selectedProduct.parts;
        // }
    }
}
