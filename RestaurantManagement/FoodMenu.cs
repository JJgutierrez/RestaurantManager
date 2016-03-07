using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class FoodMenu
    {
        public void ViewMenu(string menuPath)
        {
            FileReader filereader = new FileReader();
            filereader.OpenPdfMenu(menuPath);
        }


    }
}
