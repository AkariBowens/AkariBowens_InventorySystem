using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    internal class InHouse : Part
    {
        public InHouse(int PartIDnum, string partName, int partInStock, double partPrice, int partMin, int partMax, int machineID)
            : base(PartIDnum, partName, partInStock, partPrice, partMin, partMax)
             {
                InHouseID = machineID;
             }
       
        public int InHouseID { get; set; }

    }
}
