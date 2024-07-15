// See https://aka.ms/new-console-template for more information
//using entityframedemo.Models;
using databasedemo.Models;

Employee employee = new Employee();

Console.WriteLine("1. Insert");
Console.WriteLine("2. Display Employee record in descending order with respect to employee salary using EntityFramework");
Console.WriteLine("3. Display employee whose salary is greater than 50,000 and whose address is Kathmandu");
Console.Write("\nChoose an option: ");

string option = Console.ReadLine();

switch (option)
{
    case "1":
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter salary");
            int salary = int.Parse(Console.ReadLine());

            employee.SaveEmployee(name, address, salary);
            Console.WriteLine("\nEmployee record addded!");
        }
        break;

    case "2":
        employee.showEmployeeInOrder();
        employee.calcAggregateSalary(5);

        break;

    case "3":
        employee.salaryGreaterThan20000AddressKathmandu();
        break;
}