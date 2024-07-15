using System;
using System.Linq;

namespace CRUD_qno17
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();

                // Create
                AddStudent(context, new Student { Name = "John Doe", Age = 20, Gender = "Male" });

                // Read
                ReadStudents(context);

                // Update
                UpdateStudent(context, 1, "Jane Doe");

                // Delete
                DeleteStudent(context, 1);
            }
        }

        static void AddStudent(SchoolContext context, Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine("Student added.");
        }

        static void ReadStudents(SchoolContext context)
        {
            var students = context.Students.ToList();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}");
            }
        }

        static void UpdateStudent(SchoolContext context, int id, string newName)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                student.Name = newName;
                context.SaveChanges();
                Console.WriteLine("Student updated.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void DeleteStudent(SchoolContext context, int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
                Console.WriteLine("Student deleted.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
