using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwoOop
{
    public class Employee
    {
        public string name;
        public int age;
        public Employee(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }

        public void showEmployeDetails()
        {
            
        }

        public void displayName()
        {
            Console.WriteLine("name of employe" +name);
            Console.WriteLine("age of emoployee" +age);

        }
    }
}
