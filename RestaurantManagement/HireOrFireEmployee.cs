using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace RestaurantManagement
{
    class HireOrFireEmployee
    {
        EmployeesData employeeD = new EmployeesData();
        string filepath = @"EmployeeData.csv";
        FileReader filereader = new FileReader();
        FileWriter filewriter = new FileWriter();
        EndReport enreport = new EndReport();

        public void HireEmployee()
        {
            Console.WriteLine("Did the Employee past the interview");
            string interviewReview = Console.ReadLine().ToLower();
            if (interviewReview== "yes"||interviewReview== "y" )
            {
                employeeD.NewEmployeeEntry(filepath);
            }
            else
            {
                Console.WriteLine("No ready for this position..");
                Console.ReadKey();
            }
        }

        public void FireEmployee()
        {
            Console.WriteLine("Enter Employee Id");
            string employeeId = Console.ReadLine();

            Console.WriteLine("Enter reason to fire employee: ");
            string reason = Console.ReadLine();
            enreport.MakeFinalReaport(reason);

            DataTable employeesData = filereader.GetCsvData(filepath);
            DataRow[] rows;
            rows = employeesData.Select(employeeId);
            foreach(DataRow row in rows)
            {
                employeesData.Rows.Remove(row);
            }

            filewriter.CSVFileWriter(employeesData, filepath);  
        }
    }
}
