using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    internal class Inventory

    {
        // Attributes //
        private BindingList<Product> _allProducts = new BindingList<Product>();
        public static BindingList<Product> AllProducts = new BindingList<Product>();

        private static BindingList<Part> _allParts = new BindingList<Part>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static Part SelectedPart { get; set; }
        public static int SelectedPartIndex { get; set; }

        public static Product TempProduct { get; set; }
        public static int TempProductIndex { get; set; }

        public static int GlobalProductID { get; set; } = 1000;
        public static int GlobalPartID {get; set;} = 100;
        
        
        // Methods // 

        // ----- Product Methods ----- //

        // Adds new product to AllProducts list
        public static void addProduct(Product insertedProduct) 
        { 
            AllProducts.Add(insertedProduct);
            Console.WriteLine("Storing new product called " + insertedProduct.Name + ".\n");
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
            return foundProduct;
        }

        public static void UpdateProduct(int productIdx, Product OriginalProduct) 
        {
            // Gets item in AllProducts and updates item in AllParts on contrasting property values

            // Sets product to be changed
            Product productToChange = AllProducts[productIdx];
            
            if (productToChange.Name != OriginalProduct.Name)
            {
                Console.WriteLine("Changing ProductName " + productToChange.Name + " to " + OriginalProduct.Name + "\n");
                productToChange.Name = OriginalProduct.Name;
            }

            if (productToChange.Price != OriginalProduct.Price)
            {
                Console.WriteLine("Changing ProductPrice " + productToChange.Price + " to " + OriginalProduct.Price + "\n");
                productToChange.Price = OriginalProduct.Price;
            }

            if (productToChange.InStock != OriginalProduct.InStock)
            {
                Console.WriteLine("Changing ProductInStock " + productToChange.InStock + " to " + OriginalProduct.InStock + "\n");
                productToChange.InStock = OriginalProduct.InStock;
            }

            if (productToChange.Min != OriginalProduct.Min)
            {
                Console.WriteLine("Changing ProductMin " + productToChange.Min + " to " + OriginalProduct.Min + "\n");
                productToChange.Min = OriginalProduct.Min;
            }

            if (productToChange.Max != OriginalProduct.Max)
            {
                Console.WriteLine("Changing ProductMax " + productToChange.Max + " to " + OriginalProduct.Max + "\n");
                productToChange.Max = OriginalProduct.Max;
            }
            
            // Copies AssociatedParts from OriginalProduct to productToChange
            if (OriginalProduct.AssociatedParts.Count > 0)
            {
                productToChange.AssociatedParts.Clear();
                for (int i = 0; i < OriginalProduct.AssociatedParts.Count; i++)
                {
                    productToChange.addAssociatedPart(OriginalProduct.AssociatedParts[i]);
                    Console.WriteLine("Count: " + productToChange.AssociatedParts.Count);
                }
            }
            Console.WriteLine("Associated Parts: " + AllProducts[productIdx].AssociatedParts.Count + " in UpdateProduct");
            AllProducts.ResetBindings();    
        }
      

        // -------------------------------------------------------//

        // ----- Part Methods ----- //

        // Adds new Part to AllParts list
        public static void addPart(Part insertedPart) 
        {
            AllParts.Add(insertedPart);
            Console.WriteLine("Storing new part called " + insertedPart.Name + ".\n");
        }

        // Removes part from AllParts
        public static bool deletePart(Part selectedPart) 
         {
            
            for (int i = 0; i < AllProducts.Count; i++)
            {
                if (AllProducts[i].AssociatedParts.Contains(selectedPart))
                {
                    return false;
                }
            }
            AllParts.Remove(selectedPart);
            return true;
         }

        // Looks up a part in AllParts list
        public static Part LookupPart(int partIndex) 
        {
            Part foundPart = AllParts[partIndex];
            return foundPart; 
        }

        // Updates existing part in AllParts list
        public static void UpdatePart(int partIndex, Part currentPart)
        {
                
            Console.WriteLine("Part index: " + partIndex);
            if (currentPart is InHouse && AllParts[partIndex] is InHouse) 
            { 
                InHouse savedPart = (InHouse)currentPart;
                InHouse partToUpdate = (InHouse)AllParts[partIndex];

                // Reconfigure this later
                
                if (partToUpdate.Name != savedPart.Name)
                {
                    Console.WriteLine("Changing PartName " + partToUpdate.Name + " to " + savedPart.Name + "\n");
                    partToUpdate.Name = savedPart.Name;
                }
                if (partToUpdate.InStock != savedPart.InStock)
                {
                    Console.WriteLine("Changing PartInStock " + partToUpdate.InStock + " to " + savedPart.InStock + "\n");
                    partToUpdate.InStock = savedPart.InStock;
                }
                if (partToUpdate.Price != savedPart.Price)
                {
                    Console.WriteLine("Changing PartPrice " + partToUpdate.Price + " to " + savedPart.Price + "\n");
                    partToUpdate.Price = savedPart.Price;
                }

                if (partToUpdate.Min != savedPart.Min)
                {
                    Console.WriteLine("Changing PartMin " + partToUpdate.Min + " to " + savedPart.Min + "\n");
                    partToUpdate.Min = savedPart.Min;
                }
                if (partToUpdate.Max != savedPart.Max)
                {
                    Console.WriteLine("Changing PartMax " + partToUpdate.Max + " to " + savedPart.Max + "\n");
                    partToUpdate.Max = savedPart.Max;
                }

                if (partToUpdate.InHouseID != savedPart.InHouseID)
                {
                    Console.WriteLine("Changing PartInHouseID " + partToUpdate.InHouseID + " to " + savedPart.InHouseID + "\n");
                    partToUpdate.InHouseID = savedPart.InHouseID;
                }

                

            }
            else if (currentPart is InHouse && AllParts[partIndex] is Outsourced)
            {
                InHouse savedPart = (InHouse)currentPart;
               
                InHouse NewPart = new InHouse(AllParts[partIndex].PartID, savedPart.Name, savedPart.InStock, (double)savedPart.Price, savedPart.Min, savedPart.Max, savedPart.InHouseID);
                
                // Removes part at partIndex
                Console.WriteLine("Remove part at index " + partIndex);
                AllParts.RemoveAt(partIndex);

                //Adds part at partIndex
                Console.WriteLine("Insert new part at index " + partIndex);
                AllParts.Insert(partIndex, NewPart);

               

            }

            else if (currentPart is Outsourced && AllParts[partIndex] is Outsourced)
            {
                Outsourced savedPart = (Outsourced)currentPart;
                Outsourced partToUpdate = (Outsourced)AllParts[partIndex];

                if (partToUpdate.Name != savedPart.Name)
                {
                    Console.WriteLine("Changing PartName " + partToUpdate.Name + " to " + savedPart.Name + "\n");
                    partToUpdate.Name = savedPart.Name;
                }
                if (partToUpdate.InStock != savedPart.InStock)
                {
                    Console.WriteLine("Changing PartInStock " + partToUpdate.InStock + " to " + savedPart.InStock + "\n");
                    partToUpdate.InStock = savedPart.InStock;
                }
                if (partToUpdate.Price != savedPart.Price)
                {
                    Console.WriteLine("Changing PartPrice " + partToUpdate.Price + " to " + savedPart.Price + "\n");
                    partToUpdate.Price = savedPart.Price;
                }

                if (partToUpdate.Min != savedPart.Min)
                {
                    Console.WriteLine("Changing PartMin " + partToUpdate.Min + " to " + savedPart.Min + "\n");
                    partToUpdate.Min = savedPart.Min;
                }
                if (partToUpdate.Max != savedPart.Max)
                {
                    Console.WriteLine("Changing PartMax " + partToUpdate.Max + " to " + savedPart.Max + "\n");
                    partToUpdate.Max = savedPart.Max;
                }

                if (partToUpdate.Company != savedPart.Company)
                {
                    Console.WriteLine("Changing ProductName " + partToUpdate.Company + " to " + savedPart.Company + "\n");
                    partToUpdate.Company = savedPart.Company;
                }

              
            }

            else if(currentPart is Outsourced && AllParts[partIndex] is InHouse)
            {
                Outsourced savedPart = (Outsourced)currentPart;
                
                Outsourced NewPart = new Outsourced(AllParts[partIndex].PartID, savedPart.Name, savedPart.InStock, (double)savedPart.Price, savedPart.Min, savedPart.Max, savedPart.Company);
                
                // Removes part at partIndex
                Console.WriteLine("Remove part at index " + partIndex);
                AllParts.RemoveAt(partIndex);

                //Adds part at partIndex
                Console.WriteLine("Insert new part at index " + partIndex);

                AllParts.Insert(partIndex, NewPart);

                
            }
            // Refreshes AllParts list with updated part
            AllParts.ResetBindings();

            return;
        }

        static Inventory()
        {
            // Adds default parts to AllProducts
            AllProducts.Add(new Product(GlobalProductID++, "testProduct1", 4, 210.99, 0, 5));
            AllProducts.Add(new Product(GlobalProductID++, "testProduct2", 1, 211.99, 0, 2));
            AllProducts.Add(new Product(GlobalProductID++, "testProduct3", 1, 212.99, 0, 3));

            // Adds default parts to AllParts
            AllParts.Add(new InHouse(GlobalPartID++, "Right Angle Fitting", 3, 213.99, 0, 8, 102256));
            AllParts.Add(new Outsourced(GlobalPartID++, "testPart5", 1, 214.99, 0, 3, "DirectLine Inc."));
            AllParts.Add(new InHouse(GlobalPartID++, "testPart6", 2, 215.99, 0, 6, 1065578));

        }
    };
    
}
