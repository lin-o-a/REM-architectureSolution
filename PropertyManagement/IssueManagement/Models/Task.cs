using System;

namespace REM.Logic.RealEstateManagement.PropertyManagement.IssueManagement.Models
{
    public class Task
    {
        public Guid Id;
        public string Description;
        public Guid IssueId;

        public Issue Issue;
    }
}
