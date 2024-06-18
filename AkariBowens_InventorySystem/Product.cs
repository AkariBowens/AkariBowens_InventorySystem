using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AkariBowens_InventorySystem
{
    internal class Product
    {

        // Attributes 
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max {get; set; } 
        public int ProdIdx { get; set; }

        public Product(int productIDNum, string productName, int numInStock, double productPrice, int Minimum, int Maximum)
        {
            // ID is auto created and incremental
            // int productIDNum = 
            ProductID = productIDNum;
            Name = productName;
            InStock = numInStock;
            Price = (decimal)productPrice;
            Min = Minimum;
            Max = Maximum;
            Console.WriteLine("Storing new product called " + productName + ".\n");
        }

        // Should i put an object in this object?

        // -----Methods----- //
        public void addAssociatedPart(Part newPart) 
        {
            //Adds part to TempProduct
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
        public void ResetProduct(Product currentProduct)
        {
            currentProduct = new Product(0, "", 0, 0, 0, 0);
        }
      
    }
}
