

using Crud_firstapproach.Models;


StudentDB std1 = new StudentDB();

Console.WriteLine("Enter your Name:");
string name = Console.ReadLine();

Console.WriteLine("Enter your Address:");
string address = Console.ReadLine();

Console.WriteLine("Enter your Salary:");
double salary = double.Parse(Console.ReadLine());

Console.WriteLine("Enter you Age:");
int age = int.Parse(Console.ReadLine());


std1.SaveStudent(name, address, salary, age);
Console.WriteLine("Employee Record Inserted:");
Console.ReadLine();