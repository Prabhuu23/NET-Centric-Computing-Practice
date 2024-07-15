using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace BankApplication
{
    public class BankContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Bankdatabase;Trusted_Connection=True;");
          
        }

        public void InsertCustomer(string accountNo, string name, string address, double balance)
        {
            Customer customer = new Customer
            {
                AccountNo = accountNo,
                Name = name,
                Address = address,
                Balance = balance
            };

            Customers.Add(customer);
            SaveChanges();
        }

        public void DisplayCustomersWithBalanceGreaterThan(double amount)
        {
            var customers = Customers.Where(c => c.Balance > amount);

            foreach (var customer in customers)
            {
                Console.WriteLine($"Account No: {customer.AccountNo}, Name: {customer.Name}, Address: {customer.Address}, Balance: {customer.Balance}");
            }
        }

    }
}
