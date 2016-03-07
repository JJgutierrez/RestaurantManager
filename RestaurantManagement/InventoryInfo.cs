using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Inventory
    {
        public string FoodItem { get; set; }
        public string Category { get; set; }
        public string SizeDescription { get; set; }
        public int PurchaseUnitCost { get; set; }
        public int Units { get; set; }

        public decimal Cost { get; set; }

        public Inventory(string fooditem, string category, string sizeDescription, int units, decimal cost)
        {
            FoodItem = fooditem;
            Category = category;
            SizeDescription = sizeDescription;
            Units = units;
            Cost = cost;
        }
    }
}
