using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }
    public string Gender { get; set; }
}
