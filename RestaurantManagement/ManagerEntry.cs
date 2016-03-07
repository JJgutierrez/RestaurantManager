using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class ManagerEntry
    {
        string menuFile = @"dinner-menu.pdf";
        string fileReport = @"Todayreport.txt";
        ProductInventory inventory = new ProductInventory();
        HireOrFireEmployee HFemployee = new HireOrFireEmployee();
        EndReport report = new EndReport();
        Reservation reservation = new Reservation();
        static  void ManagerOptions()
        {
            Console.WriteLine("\n***********************************"
                             +"\n     1 - View Today Menu           "
                             +"\n     2 - View Inventory            "
                             +"\n     3 - Edit Inventory            "
                             +"\n     4 - New Employee              "
                             +"\n     5 - Delete employee           "
                             +"\n     6 - Created daily Report      "
                             +"\n     7 - View report               "
                             +"\n     8 - Created Reservation       "
                             +"\n     9 - Exit                      "
                             +"\n***********************************");
        }
        public void Manager()
        {
            while (true)
            {
                ManagerOptions();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        FoodMenu menu = new FoodMenu();
                        menu.ViewMenu(menuFile);
                        Console.ReadLine();
                        Manager();
                        break;
                    case "2":
                        Console.Clear();
                        inventory.ViewInventory();
                        Console.ReadKey();
                        break;
                    case "3":
                        inventory.AddToInventory();
                        break;
                    case "4":
                        HFemployee.HireEmployee();
                        break;

                    case "5":
                        HFemployee.FireEmployee();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Please Enter your Coments about Today:");
                        string coments = Console.ReadLine();
                        report.MakeFinalReaport(coments);
                        Console.WriteLine("updating data .........");
                        Manager();
                        break;
                    case "7":
                        report.Viewreport(fileReport);
                        break;
                    case "8":
                        reservation.MakeReservation();
                        break;
                    case "9":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            }
        }
    }

}
