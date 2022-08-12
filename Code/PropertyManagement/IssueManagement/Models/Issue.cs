using REM.Logic.RealEstateManagement.PropertyManagement.IssueManagement.Models;
using System;
using System.Collections.Generic;

public class Issue
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<Task> Tasks { get; set; }
}