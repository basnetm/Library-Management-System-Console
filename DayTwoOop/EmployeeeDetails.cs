using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DayTwoOop
{
    public class EmployeeeDetails
    {
        public List<Employee>employees=new List<Employee>();

        public void addEmployee(Employee emp)
        {
            employees.Add(emp);

            Console.WriteLine("employe added to library.");
        }

    }
}
