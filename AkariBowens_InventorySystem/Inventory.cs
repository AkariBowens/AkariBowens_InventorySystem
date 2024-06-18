﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    internal class Inventory

    {
        // Attributes //
        public static BindingList<Product> AllProducts = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static Part SelectedPart { get; set; }
        public static Product TempProduct { get; set; }    

        // Methods // 

        // ----- Product Methods ----- //

        // Adds new product to AllProducts list
        public static void addProduct(Product insertedProduct) 
        { 
            AllProducts.Add(insertedProduct);
        }

        // Removes product from AllProducts
        public static bool removeProduct(int indexProductSelected)
        {
            AllProducts.RemoveAt(indexProductSelected);
            return true;
        }

        public static Product LookupProduct(int productIndex) 
        {
            Product foundProduct = AllProducts[productIndex];
            Console.Write("Found " +  AllProducts[productIndex] + "\n");
            return foundProduct;
        }

        public static void UpdateProduct(int productIdx, Product TempProduct) 
        {
            // Gets item in AllProducts, updates on contrasting values in same property, updates, and saves
            
            // Sets product to be changed
            Product productToChange = AllProducts[productIdx];
            Console.WriteLine("Associated Parts:" + TempProduct.AssociatedParts.Count);
            

            // If name taken...?
            if (productToChange.Name != TempProduct.Name)
            {
                Console.WriteLine("Changing ProductName " + productToChange.Name + " to " + TempProduct.Name + "\n");
                productToChange.Name = TempProduct.Name;
            }

            if (productToChange.Price != TempProduct.Price)
            {
                Console.WriteLine("Changing ProductPrice " + productToChange.Price + " to " + TempProduct.Price + "\n");
                productToChange.Price = TempProduct.Price;
            }

            if (productToChange.InStock != TempProduct.InStock)
            {
                Console.WriteLine("Changing ProductInStock " + productToChange.InStock + " to " + TempProduct.InStock + "\n");
                productToChange.InStock = TempProduct.InStock;
            }

            if (productToChange.Min != TempProduct.Min)
            {
                Console.WriteLine("Changing ProductMin " + productToChange.Min + " to " + TempProduct.Min + "\n");
                productToChange.Min = TempProduct.Min;
            }

            if (productToChange.Max != TempProduct.Max)
            {
                Console.WriteLine("Changing ProductMax " + productToChange.Max + " to " + TempProduct.Max + "\n");
                productToChange.Max = TempProduct.Max;
            }

            
            Console.WriteLine("Associated Parts:" + AllProducts[productIdx].AssociatedParts.Count);
            AllProducts.ResetBindings();    
        }

        public static bool removeAssociatedPart(int associatedPart)
        {
            // Accessed through "Main Screen" or "Add Product"
            if (associatedPart < 0 || associatedPart > AllParts.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Part lookupAssociatedPart(int partIndex)
        {
            Part partAssociated = AllParts[partIndex];
            
            return partAssociated;
        }

        // -------------------------------------------------------//

        // ----- Part Methods ----- //

        // Adds new Part to AllParts list
        public static void addPart(Part insertedPart) 
        {
            AllParts.Add(insertedPart);
        }

        // Removes part from AllParts
         public static bool deletePart(Part selectedPart) 
         {
            AllParts.Remove(selectedPart);
            return true;
         }

        // Looks up a part in AllParts list
        
        public static Part lookupPart(int partIndex) 
        {
            Part foundPart = AllParts[partIndex];

            Console.Write("Found " + AllParts[partIndex] + "\n");
            return foundPart;
               
        }

        // ----- Add from Main Screen partsSearchBar----- //
        // Updates existing part in AllParts list
        public static void updatePart(int partIndex, Part currentPart) 
        {
            // check which field is different, then..
            // lookup part, return it, fill modify page
            return;
        }

        static Inventory()
        {
            // maybe create the IDnum algo in here and pass it to each newly added Part/Product
            // Adds default parts to AllProducts
            AllProducts.Add(new Product(1, "testProduct1", 1, 210.99, 0, 1));
            AllProducts.Add(new Product(2, "testProduct2", 1, 211.99, 0, 1));
            AllProducts.Add(new Product(3, "testProduct3", 1, 212.99, 0, 1));

            // Adds default parts to AllParts
            AllParts.Add(new InHouse(4, "testPart4", 1, 213.99, 0, 1, 102256));
            AllParts.Add(new Outsourced(5, "testPart5", 1, 214.99, 0, 1, "DirectLine Inc."));
            AllParts.Add(new InHouse(6, "testPart6", 1, 215.99, 0, 1, 1065578));

        }
    };

    //
    
}
