using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Reservation
    {
        string reservationFile = @"Reservation";
        string todaydate = (DateTime.Now).ToString("d");
        FileWriter filewriter = new FileWriter();
        public void MakeReservation()
        {
            Console.WriteLine("Enter name Of the costumer: ");
            string costumer = Console.ReadLine();
            Console.WriteLine("How many people: ");
            string amount = Console.ReadLine();
            Console.WriteLine("Enter phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Time for reservation: ");
            string Rtime = Console.ReadLine();

            string reservationInfo = String.Format("client :{0} for {1} phone Number:{2} at this time: {3}", costumer, amount, phoneNumber, Rtime);
            filewriter.CreatedReport(reservationInfo, reservationFile + todaydate + ".txt");
        }
            
    }
}
