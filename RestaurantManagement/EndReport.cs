using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class EndReport
    {
        string dateToday = (DateTime.Now).ToString("d");
        string reportFile = @"DayReport";
        FileWriter filewriter = new FileWriter();
        FileReader filereader = new FileReader();

        public void MakeFinalReaport(string comments)
        {
            //Console.WriteLine("Comments about today:");
            //string comments = Console.ReadLine();
            filewriter.CreatedReport(comments, reportFile + dateToday+".txt");
        }

        public void Viewreport(string file)
        {
            filereader.OpenReport(file);
        }
    }
}
