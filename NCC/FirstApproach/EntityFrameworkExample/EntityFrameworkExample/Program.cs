using System;
using System.Linq;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Compute aggregate salary of 5 employees and display employee records in descending order of salary.");
            Console.WriteLine("2. Select employees with salary greater than 50000 and address as Kathmandu.");
            Console.WriteLine("3. Create a table in the database for customers and insert 5 customer records. Display customers with balance greater than 50000.");
            Console.Write("Enter your choice: ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                Console.Write("Enter your choice: ");
            }

            switch (choice)
            {
                case 1:
                    ComputeAggregateSalaryAndDisplay();
                    break;
                case 2:
                    SelectEmployeesWithCriteria();
                    break;
                case 3:
                    CreateCustomerTableAndInsertRecords();
                    break;
            }
        }

        static void ComputeAggregateSalaryAndDisplay()
        {
            using (var context = new EmployeeDbContext())
            {
                var aggregateSalary = context.Employees.Take(5).Sum(e => e.Salary);
                var employees = context.Employees.OrderByDescending(e => e.Salary).Take(5).ToList();

                Console.WriteLine($"Aggregate Salary of 5 employees: {aggregateSalary}");
                Console.WriteLine("Employee Records in descending order of salary:");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Name: {employee.Name}, Address: {employee.Address}, Salary: {employee.Salary}");
                }
            }
        }

        static void SelectEmployeesWithCriteria()
        {
            using (var context = new EmployeeDbContext())
            {
                var employees = context.Employees.Where(e => e.Salary > 50000 && e.Address == "Kathmandu").ToList();

                Console.WriteLine("Employees with salary greater than 50000 and address as Kathmandu:");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Name: {employee.Name}, Address: {employee.Address}, Salary: {employee.Salary}");
                }
            }
        }

        static void CreateCustomerTableAndInsertRecords()
        {
            using (var context = new BankDbContext())
            {
                // Create the Customers table if it doesn't exist
                context.Database.ExecuteSqlCommand(@"
                    CREATE TABLE IF NOT EXISTS Customers (
                        Id INT PRIMARY KEY IDENTITY,
                        AccountNo INT,
                        Name NVARCHAR(100),
                        Address NVARCHAR(100),
                        Balance DECIMAL(18, 2)
                    )
                ");

                // Insert 5 customer records
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Enter details for customer {i}:");
                    Console.Write("Account No: ");
                    int accountNo = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Address: ");
                    string address = Console.ReadLine();

                    Console.Write("Balance: ");
                    decimal balance = decimal.Parse(Console.ReadLine());

                    context.Database.ExecuteSqlCommand(@"
                        INSERT INTO Customers (AccountNo, Name, Address, Balance)
                        VALUES ({0}, {1}, {2}, {3})
                    ", accountNo, name, address, balance);
                }

                // Display customers with balance greater than 50000
                var richCustomers = context.Customers.Where(c => c.Balance > 50000).ToList();
                Console.WriteLine("Customers with balance greater than 50000:");
                foreach (var customer in richCustomers)
                {
                    Console.WriteLine($"Account No: {customer.AccountNo}, Name: {customer.Name}, Address: {customer.Address}, Balance: {customer.Balance}");
                }
            }
        }
    }
}
