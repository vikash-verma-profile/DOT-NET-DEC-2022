using System;
using System.Collections.Generic;

namespace Performance.Models;

public partial class School
{
    public int SchoolId { get; set; }

    public string? Name { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? PostalZipCode { get; set; }

    public string? City { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
