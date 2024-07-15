using System;
using System.Collections.Generic;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDb employeeDb = new EmployeeDb();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Retrieve");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter employee name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter employee address: ");
                        string address = Console.ReadLine();

                        Console.Write("Enter employee salary: ");
                        int salary = int.Parse(Console.ReadLine());

                        employeeDb.SaveEmployee(name, salary, address);

                        Console.WriteLine("Employee data inserted!");
                        break;

                    case "2":
                        // Load employees and display them
                        Console.WriteLine("\nList of Employees:");
                        Console.WriteLine("-------------------");
                        List<TbEmployee> employees = employeeDb.LoadEmployees();
                        foreach (var employee in employees)
                        {
                            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}, Address: {employee.Address}");
                        }
                        break;

                    case "3":
                        Console.Write("Enter employee ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());

                        Console.Write("Enter updated employee name: ");
                        string updatedName = Console.ReadLine();

                        Console.Write("Enter updated employee address: ");
                        string updatedAddress = Console.ReadLine();

                        Console.Write("Enter updated employee salary: ");
                        int updatedSalary = int.Parse(Console.ReadLine());

                        employeeDb.UpdateEmployee(updateId, updatedName, updatedSalary, updatedAddress);

                        Console.WriteLine("Employee data updated!");
                        break;

                    case "4":
                        Console.Write("Enter employee ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());

                        employeeDb.DeleteEmployee(deleteId);

                        Console.WriteLine("Employee data deleted!");
                        break;

                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine(); // Wait for user to press Enter before displaying the menu again
                Console.Clear(); // Clear the console screen for better readability
            }
        }
    }
}
