using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Program
    {
        static void Main(string[] arg)
        {
            try
            {
                //ProductInventory pi = new ProductInventory();
                //pi.AddToInventory();
                ManagerEntry me = new ManagerEntry();
                me.Manager();
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong .......{0}", e);
            }
        }
    }
}
