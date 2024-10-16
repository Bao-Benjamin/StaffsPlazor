using System;
using System.Collections.Generic;

namespace BlazorStaff.Models;

public partial class Staff
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateOnly? StartingDate { get; set; }

    public int? GenderId { get; set; }

    public int? DepartmentId { get; set; }
}
