using System;
using System.Data.SqlClient;

namespace StudentRecordAppq17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection string to your database
            string connectionString = "Data Source=PRABHU-RTX-3070\\SQLEXPRESS;Initial Catalog=dbq17;Integrated Security=True;Encrypt=False";

            // Insert a new student record
            InsertStudent(connectionString, 5, "Eva", 18, "Female");

            // Fetch student records by gender
            FetchStudentsByGender(connectionString, "Female");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void InsertStudent(string connectionString, int id, string name, int age, string gender)
        {
            string query = "INSERT INTO tblStudent (id, name, age, gender) VALUES (@Id, @Name, @Age, @Gender)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Gender", gender);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");
                }
            }
        }

        static void FetchStudentsByGender(string connectionString, string gender)
        {
            string query = "SELECT * FROM tblStudent WHERE gender = @Gender";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Gender", gender);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine($"Student records with gender '{gender}':");
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                int age = reader.GetInt32(2);
                                Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No student records found with gender '{gender}'.");
                        }
                    }
                }
            }
        }
    }
}
