using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Employee
    { 
        string Name { get; set; }
        string LastName { get; set; }
        string Age { get; set; }
        string Position { get; set; }
        string EmployeeId { get; set; }

        public Employee(string name, string lastname, string age, string position, string employeeid)
        {
            Name = name;
            LastName = lastname;
            Age = age;
            Position = position;
            EmployeeId = EmployeeId;

        }
    }
}
