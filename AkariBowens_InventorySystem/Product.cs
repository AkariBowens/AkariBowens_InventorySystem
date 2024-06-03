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
        // private List<Part> Parts = new List<Part>();
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int inStock { get; set; }
        public int Min { get; set; }
        public int Max {get; set; }

        public Product(int productIDNum, string productName, int numInStock, double productPrice, int Minimum, int Maximum, BindingList<Part> PartsAssociated = default)
        {
            // ID is auto created and incremental
            // int productIDNum = 


            ProductID = productIDNum;

            Name = productName;
            inStock = numInStock;
            Price = (decimal)productPrice;
            Min = Minimum;
            Max = Maximum;
            AssociatedParts = PartsAssociated;
            
            Console.WriteLine("Storing new product called " + productName + ".\n");

        }

        

      

        // -----Methods----- //

        // static void addAssociatedPart(Part newPart) 
        // {
            //adds part to product
            // Product.AssociatedParts.Add(newPart);
        // }
        
        //static bool removeAssociatedPart(int partIDNum) 
        //{ 
            // returns bool
        //}

        //static Part lookupAssociatedPart(int partIDNum)
        //{
            // returns Part
        //}

    }
}
