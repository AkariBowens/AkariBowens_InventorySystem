using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    internal class InHouse : Part
    {
        public InHouse(int partIDnum, string partName, int partInStock, double partPrice, int partMin, int partMax, int machineID)
            : base(partIDnum, partName, partInStock, partPrice, partMin, partMax) => InHouseID = machineID;

        // Use after I automate ID
        // public InHouse(int partIDnum, string partName, int partInStock, double partPrice, int partMin, int partMax)
        // : base(partIDnum, partName, partInStock, partPrice, partMin, partMax)
        // {

        // }
       
        public int InHouseID { get; set; }

        // public static InHouse SelectedInHouse { get; set; }
        
    }
}
