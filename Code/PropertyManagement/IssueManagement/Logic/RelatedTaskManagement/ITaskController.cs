using REM.Logic.RealEstateManagement.PropertyManagement.IssueManagement.Models;
using System;
using System.Collections.Generic;

public interface ITaskController {
    Guid Create(Guid issueId, ICollection<Task> tasks);
}
