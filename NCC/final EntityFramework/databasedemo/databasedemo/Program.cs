// See https://aka.ms/new-console-template for more information
using databasedemo.Models;
using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter address:");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter salary:");
                        int salary;
                        while (!int.TryParse(Console.ReadLine(), out salary))
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value for salary.");
                        }

                        employee.SaveEmployee(name, address, salary);
                        Console.WriteLine("\nEmployee record added!");
                        Console.ReadLine
                    }
                    break;

                case "2":
                    employee.ShowEmployeeInOrder();
                    employee.CalcAggregateSalary(5);
                    break;

                case "3":
                    employee.SalaryGreaterThan50000AddressKathmandu();
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }
}
