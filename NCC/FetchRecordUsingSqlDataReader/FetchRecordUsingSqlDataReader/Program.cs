using System;
using System.Data.SqlClient;

namespace FetchRecordUsingSqlDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace "Your Data Connection Connection String" with the actual connection string you copied from Visual Studio
            string connectionString = "Data Source=PRABHU-RTX-3070\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True;Encrypt=False";

            string query = "SELECT * FROM Employees";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);

                                Console.WriteLine($"ID: {id}, Name: {name}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No rows found.");
                        }
                    }
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
