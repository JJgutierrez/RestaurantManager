using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RestaurantManagement
{
    class EmployeesData
    {
        FileReader filereader = new FileReader();
        FileWriter filewriter = new FileWriter();


        public void NewEmployeeEntry(string filePath)
        {
            DataTable temEmployees = filereader.GetCsvData(filePath);
            Console.WriteLine("Enter Name of new Employee: ");
            string name  = Console.ReadLine();
            Console.WriteLine("Enter Lastname: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter age : ");
            string age = Console.ReadLine();
            Console.WriteLine("Enter Position: ");
            string position = Console.ReadLine();
            Console.WriteLine("Enter Employee Id: ");
            string employeeId = Console.ReadLine();

            DataRow newrow = temEmployees.Rows.Add();
            newrow[0] = name;
            newrow[1] = lastname;
            newrow[2] = age;
            newrow[3] = position;
            newrow[4] = employeeId;
            temEmployees.Rows.Add(newrow);
            filewriter.CSVFileWriter(temEmployees, filePath);

        }
        public DataTable GetEmployeeData(string filepath)
        {
            DataTable tempEmployess = filereader.GetCsvData(filepath);
            return tempEmployess;
        }

    }
}
