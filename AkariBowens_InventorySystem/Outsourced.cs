using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkariBowens_InventorySystem
{
    internal class Outsourced : Part
    {
        public Outsourced(int PartIDnum, string partName, int partInStock, double partPrice, int partMin, int partMax, string companyName)
            : base(PartIDnum, partName, partInStock, partPrice, partMin, partMax)
        {
            Company = companyName;

    }
        public string Company { get; set; }
    }
}
