using FirstApproach.Models;
StudentFirstDB studentFirstDB = new StudentFirstDB();

Console.WriteLine("Enter your prefered choice from the following: ");
Console.WriteLine("Enter 1 to create new students: ");
Console.WriteLine("Enter 2 to display list of students: ");
Console.WriteLine("Enter 3 to update students: ");
Console.WriteLine("Enter 4 to delete students: ");

StudentFirstDB stu = new StudentFirstDB();
string option = Console.ReadLine();
switch (option)
{
    case "1":
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your salary: ");
        int salary = int.Parse(Console.ReadLine());

        Console.Write("Enter your address: ");
        string address = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        stu.SaveStudent(name, salary, address, age);
        Console.WriteLine("Student Record Inserted!");
        break;

    case "2":
        Console.WriteLine("List of Students: ");
        List<tbStudent> students = stu.LoadStudent();
        foreach (tbStudent stud in students)
        {
            Console.WriteLine(stud.Name + " " + stud.Salary + " " + stud.Address + " " + stud.Age + " ");
        }
        break;

    case "3":
        Console.WriteLine("Enter the ID of the student you want to search!");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your name: ");
        string uname = Console.ReadLine();

        Console.Write("Enter your salary: ");
        int usalary = int.Parse(Console.ReadLine());

        Console.Write("Enter your address: ");
        string uaddress = Console.ReadLine();

        Console.Write("Enter your age: ");
        int uage = int.Parse(Console.ReadLine());

        stu.UpdateStudent(id, uname, usalary, uaddress, uage);
        Console.WriteLine("Student Record Inserted!");
        break;

    case "4":
        Console.Write("Enter ID of student to delete: ");
        int delid = Convert.ToInt32(Console.ReadLine());
        stu.DeleteStudent(delid);
        Console.WriteLine("Student Record deleted.");

        break;

    default:
        Console.WriteLine();
        break;

}