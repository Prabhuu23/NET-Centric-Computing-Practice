using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    // Declare variables - id, name, address, and gender
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Gender { get; set; }

    // ToString method that returns id, name, address, and gender
    public override string ToString()
    {
        return $"{Id} {Name} {Address} {Gender}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Insert Student Record");
            Console.WriteLine("2. Display Student Records");
            Console.WriteLine("3. Display Total Number of Students");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    InsertStudent(students);
                    break;
                case "2":
                    DisplayStudents(students);
                    break;
                case "3":
                    DisplayStudentCount(students);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }

    static void InsertStudent(List<Student> students)
    {
        Console.WriteLine("Enter Student ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Student Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Student Address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter Student Gender:");
        string gender = Console.ReadLine();

        students.Add(new Student { Id = id, Name = name, Address = address, Gender = gender });
        Console.WriteLine("Student record added successfully!");
    }

    static void DisplayStudents(List<Student> students)
    {
        Console.WriteLine("\nID  Name   Address        Gender");
        Console.WriteLine("+++++++++++++++++++++++++++++++");
        foreach (Student student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }

    static void DisplayStudentCount(List<Student> students)
    {
        Console.WriteLine($"\nTotal number of students: {students.Count}");
    }
}
