using System;

namespace StudentRecordSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseHelper.InsertStudentRecord(1, "John Doe", "123 Main St", "Male");
            DatabaseHelper.InsertStudentRecord(2, "Jane Smith", "456 Elm St", "Female");

            DatabaseHelper.DisplayTotalStudents();

            Console.ReadLine();
        }
    }
}
