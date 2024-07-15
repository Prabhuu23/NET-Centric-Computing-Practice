using EntityFramework.Models;

EmployeeDB emp = new EmployeeDB();

Console.WriteLine("1. INSERT");
Console.WriteLine("2. DISPLAY EMPLOYEE RECORD IN DESCENDING ORDER WITH REPECT TO EMPLOYEE SALARY");
Console.WriteLine("3. DISPLAY EMPLOYEE WHOSE SALARY IS GREATER THAN 50,000 AND WHOSE ADDRESS IS KATHAMANDU");

Console.Write("\nChoose an option: ");
string option = Console.ReadLine();

switch (option)
{
    case "1":
        for(int i = 0; i < 5; i++)        
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter salary: ");
            float salary = float.Parse(Console.ReadLine());

            emp.saveEmployee(name, age, address, email, salary);
            Console.WriteLine("\nEmployee record addded!");
        }
        break;

    case "2":
        emp.showEmployeeInOrder();
        emp.calcAggregateSalary(5);

        break;

    case "3":
        emp.salaryGreaterThan5000AndAddressKathmandu();
        break;
}