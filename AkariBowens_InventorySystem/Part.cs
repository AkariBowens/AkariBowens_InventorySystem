using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    // class Part is abstract
    // add abstract keyword
    internal class Part
    {
        // Attributes
        // public int PartID;
        public int PartID { get; set; }

        // public string Name;
        public string Name { get; set; }

        // public int InStock;
        public int InStock { get; set; }

        // public decimal Price
        public decimal Price { get; set; }

        // public int Max;
        public int Max { get; set; }
        // public int Min;
        public int Min { get; set; }


        // Add "Inhouse" & "Outsourced" -- either/or -- inheritance
        public int MachineID { get; set; }
        public string CompanyName { get; set; }

        // Part constructor
        // add two variables, 1 for company, one for machineid - both optional and boolean, if bool == true etc...
        public Part(int partIDnum, string partName, int partInStock, double partPrice, int partMin, int partMax, int machinePartID = default, string partCompanyName = default)
        {
            PartID = partIDnum;
            Name = partName;
            InStock = partInStock;
            // to decimal
            Price = (decimal)partPrice;
            Min = partMin;
            Max = partMax;
            // int machineID; - if inHouse
            machinePartID = MachineID;
            partCompanyName = CompanyName;
            Console.WriteLine("Storing new product called " + partName + ".\n");
            
        }

        // Part creation shorthand Part.argsList(<struct> or string<>){return Part("","","",...)
    }

    
}
