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
            // This should increment product id
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
            Console.WriteLine("Associated Parts: " + TempProduct.AssociatedParts.Count);
            

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

            
            Console.WriteLine("Associated Parts: " + AllProducts[productIdx].AssociatedParts.Count + " in UpdateProduct");
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

        public static Part LookupAssociatedPart(int partIndex)
        {
            Part partAssociated = AllParts[partIndex];
            
            return partAssociated;
        }

        // -------------------------------------------------------//

        // ----- Part Methods ----- //

        // Adds new Part to AllParts list
        public static void addPart(Part insertedPart) 
        {
            // This should increment part id
            AllParts.Add(insertedPart);
        }

        // Removes part from AllParts
        public static bool deletePart(Part selectedPart) 
         {
            // check if selectedPart is in AllProducts[i].AssociatedParts[j] or AllProducts[i].AssociatedParts.Contains(SelectedPart)
            // retrun false if part is associated w/ a product
            for (int i = 0; i < AllProducts.Count; i++)
            {
                if (AllProducts[i].AssociatedParts.Contains(selectedPart))
                {
                    return false;
                }
                // return false;
            }
            AllParts.Remove(selectedPart);
            return true;
         }

        // Looks up a part in AllParts list
        public static Part LookupPart(int partIndex) 
        {
            Part foundPart = AllParts[partIndex];

            Console.Write("Found " + AllParts[partIndex] + "\n");
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
            AllParts.Add(new InHouse(GlobalPartID++, "testPart4", 3, 213.99, 0, 8, 102256));
            AllParts.Add(new Outsourced(GlobalPartID++, "testPart5", 1, 214.99, 0, 3, "DirectLine Inc."));
            AllParts.Add(new InHouse(GlobalPartID++, "testPart6", 2, 215.99, 0, 6, 1065578));

        }
    };
    
}
