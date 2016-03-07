using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace RestaurantManagement
{
    class ProductInventory
    {
        FileReader freader = new FileReader();
        FileWriter fwriter = new FileWriter();
        private string InventoryMonth = @"InventoryMarch2015.csv";
        public void AddToInventory()
        {
            DataTable tempInventory = freader.GetCsvData(InventoryMonth);
            Console.WriteLine("Enter food Item: ");
            string foodItem = Console.ReadLine();
            Console.WriteLine("Enter category: ");
            string category = Console.ReadLine();
            Console.WriteLine("Enter size Description: ");
            string sizedescription = Console.ReadLine();
            Console.WriteLine("Enter Purchase Unit Cost: ");
            int purchaseUnitCost = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter units : ");
            int units = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cost: ");
            int cost = int.Parse(Console.ReadLine());
            DataRow newrow = tempInventory.NewRow();
            newrow[0] = foodItem;
            newrow[1] = category;
            newrow[2] = sizedescription;
            newrow[3] = purchaseUnitCost;
            newrow[4] = units;
            newrow[5] = cost;
            tempInventory.Rows.Add(newrow);
            fwriter.CSVFileWriter(tempInventory, InventoryMonth);
        }

        public void ViewInventory()
        {
            DataTable temInventory = freader.GetCsvData(InventoryMonth);
            freader.DisplayData(temInventory);
        }
    }
}
