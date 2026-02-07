using EmployeRental;

List<Employe> employees = new List<Employe>();

bool status = true;

while (status)
{
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Add Employee");
    Console.WriteLine("2. Show All Payslips");
    Console.WriteLine("3. Exit");

    Console.Write("Enter your choice: ");
    int ch = int.Parse(Console.ReadLine());

    if (ch == 1)
    {
        Console.Write("Enter name of employee: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter salary of employee: ");
        float salary = float.Parse(Console.ReadLine());

        Employe emp = new Employe(name, salary);
        employees.Add(emp);

        Console.WriteLine("Employee added successfully!");
    }
    else if (ch == 2)
    {
        foreach (Employe emp in employees)
        {
            emp.PrintPayslip();
        }
    }
    else if (ch == 3)
    {
        status = false;
    }
    else
    {
        Console.WriteLine("Invalid choice!");
    }
}
