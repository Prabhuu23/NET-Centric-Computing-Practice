using System;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            BankContext bankContext = new BankContext();

            // Insert 5 customer records
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Pratik Khadka");
                Console.WriteLine("1022");
                Console.WriteLine($"Enter details for customer {i}:");
                Console.Write("Account No: ");
                string accountNo = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());

                bankContext.InsertCustomer(accountNo, name, address, balance);
            }

            // Display customers with balance > 20000
            Console.WriteLine("Customers with balance greater than 20000:");
            bankContext.DisplayCustomersWithBalanceGreaterThan(20000);

        }
    }
}
