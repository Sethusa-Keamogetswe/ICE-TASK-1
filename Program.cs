using System;

class Program
{
    static void Main(string[]args)
    {
        Employee[]  employees = new Employee[6];

        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = new Employee();

            Console.WriteLine("Enter employee" + (i + 1) + "details");

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            employees[i].setName(name);

            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();
            employees[i].setSurname(surname);

            Console.WriteLine("Enter department (E/H/S): ");
            char dep = Convert.ToChar(Console.ReadLine());
            employees[i].setDepartmentName(dep);

            Console.WriteLine("Enter monthly sales: ");
            double sales = Convert.ToDouble(Console.ReadLine());
            employees[i].setSales(sales);

            Console.WriteLine();


        }
        Console.WriteLine("\nEmployee information\n");

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Employee" + (i + 1) + "details");
            Console.WriteLine("Name: " + employees[i].getName());
            Console.WriteLine("Surname: " + employees[i].getSurname());
            Console.WriteLine("Department: " + employees[i].getDepartmentName());
            Console.WriteLine("Salary: " + employees[i].calcSalary());
            Console.WriteLine("---------------------------");
        }
    }
}
