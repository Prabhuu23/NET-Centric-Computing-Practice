using System;
using System.Collections.Generic;

namespace EntityFramework.Models;

public partial class TbEntityFramework
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public int? Age { get; set; }

    public double? Salary { get; set; }
}
