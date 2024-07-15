using System;
using System.Data.SqlClient;

namespace StudentRecordSystem
{
    public static class DatabaseHelper
    {
        private const string connectionString = "Server=localhost;Database=Newnewdb;Integrated Security=True;";


        public static void InsertStudentRecord(int id, string name, string address, string gender)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO tblStud (id, name, address, gender) VALUES (@id, @name, @address, @gender)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DisplayTotalStudents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM tblStud";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    Console.WriteLine("Total number of students: " + count);
                }
            }
        }
    }
}
