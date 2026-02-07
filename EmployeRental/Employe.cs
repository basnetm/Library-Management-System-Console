using System;

namespace EmployeRental
{
    public class Employe
    {
        public string Name;
        public float Salary;
        public float Bonus;

        
        public Employe(string name, float salary)
        {
            this.Name = name;
            this.Salary = salary;

            
            if (salary > 20000)
                this.Bonus = salary * 0.10f;
            else
                this.Bonus = 0f;
        }

        public float GetGrossPay()
        {
            return Salary + Bonus;
        }

        public float GetTaxAmount()
        {
            var gross = GetGrossPay();

            if (gross <= 40000)
                return gross * 0.15f;
            else
                return gross * 0.20f;
        }

        public float GetNetPay()
        {
            return GetGrossPay() - GetTaxAmount();
        }

        public void PrintPayslip()
        {
            Console.WriteLine("\n----- PAYSLIP -----");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Bonus: {Bonus}");
            Console.WriteLine($"Gross Pay: {GetGrossPay()}");
            Console.WriteLine($"Tax: {GetTaxAmount()}");
            Console.WriteLine($"Net Pay: {GetNetPay()}");
            Console.WriteLine("-------------------\n");
        }

        

    }
}
