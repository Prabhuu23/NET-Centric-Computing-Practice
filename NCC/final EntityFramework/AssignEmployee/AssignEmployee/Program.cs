using AssignEmployee.Models;
using FirstApproach.Models;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAssignDB employeeDB = new EmployeeAssignDB();
            EmployeeContext db = new EmployeeContext();
            //CustomerContext cdb = new CustomerContext();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Enter Employee Details");
                Console.WriteLine("2. Enter Customer Details");
                Console.WriteLine("3. Compute aggregate salary of 5 employees and display records in descending order of salary");
                Console.WriteLine("4. Select employees with salary > 50000 and address is Kathmandu");
                Console.WriteLine("5. Insert 5 customer records into the database and display records with balance > 50000");
                Console.WriteLine("6. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Employee Name:");
                        string empName = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary:");
                        double empSalary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Employee Address:");
                        string empAddress = Console.ReadLine();

                        employeeDB.SaveEmployee(empName, empSalary, empAddress);
                        Console.WriteLine("Employee details saved successfully.");
                        break;


                    case 2:
                        Console.WriteLine("Enter Customer Account No:");
                        string accNo = Console.ReadLine();
                        Console.WriteLine("Enter Customer Name:");
                        string cusName = Console.ReadLine();
                        Console.WriteLine("Enter Customer Address:");
                        string cusAddress = Console.ReadLine();
                        Console.WriteLine("Enter Customer Balance:");
                        double balance = double.Parse(Console.ReadLine());

                        //employeeDB.SaveCustomer(accNo, cusName, cusAddress, balance);
                        Console.WriteLine("Customer details saved successfully.");
                        break;

                    case 3:
                        var employees = db.Employees.OrderByDescending(e => e.Salary).Take(5).ToList();
                        Console.WriteLine("Employee Records in Descending Order of Salary:");
                        foreach (var employee in employees)
                        {
                            Console.WriteLine($"Name: {employee.Emp_Name}, Salary: {employee.Salary}");
                        }

                        break;

                    case 4:
                        var employees2 = db.Employees.Where(e => e.Salary > 50000 && e.Emp_Address == "Kathmandu").ToList();

                        Console.WriteLine("Employees with Salary > 50000 and Address Kathmandu:");
                        foreach (var employee in employees2)
                        {
                            Console.WriteLine($"Name: {employee.Emp_Name}, Salary: {employee.Salary}, Address: {employee.Emp_Address}");
                        }

                        break;
                    case 5:
                       // var customers = cdb.Customers.Where(c => c.Balance > 50000).ToList();
                        Console.WriteLine("Customer Records with Balance > 50000:");
                        foreach (var customer in customers)
                        {
                            Console.WriteLine($"Account No: {customer.AccountNo}, Name: {customer.Cus_Name}, Address: {customer.Cus_Address}, Balance: {customer.Balance}");
                        }
                        break;


                    case 6:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
