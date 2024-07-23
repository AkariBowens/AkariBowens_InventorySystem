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

        public Product(int productIDNum, string productName, int numInStock, double productPrice, int Minimum, int Maximum)
        {
            ProductID = productIDNum;
            Name = productName;
            InStock = numInStock;
            Price = decimal.Round((decimal)productPrice, 2);
            Min = Minimum;
            Max = Maximum;
        }        

        // -----Methods----- //
        public void addAssociatedPart(Part newPart) 
        {
            AssociatedParts.Add(newPart);
        }
        public bool removeAssociatedPart(int partIndex) 
        {
            if (AssociatedParts.Contains(Inventory.AllParts[partIndex]))
            {
                return true;
            } else {
                return false;
            }
        }
        public static Part lookupAssociatedPart(int partIndex)
        {
            Part foundPart = Inventory.AllParts[partIndex];
            return foundPart;
        }

        
      
    }
}
