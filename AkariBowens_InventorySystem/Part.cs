using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    // class Part is abstract
    // add abstract keyword
    internal abstract class Part
    {
        // Attributes
        public int PartID { get; set; }

        // public string Name;
        public string Name { get; set; }

        // public decimal Price
        public decimal Price { get; set; }

        // public int InStock;
        public int InStock { get; set; }

        // public int Max;
        public int Max { get; set; }
        // public int Min;
        public int Min { get; set; }

        // Part constructor
        public Part(int partIDnum, string partName, int partsInStock, double partPrice , int partMin, int partMax)
        {
            PartID = partIDnum;
            Name = partName;
            InStock = partsInStock;
            
            // Formats partPrice to $XXX.XX
            Price = Math.Round((decimal)partPrice, 2);
            Min = partMin;
            Max = partMax;
        }
    }

    
}
