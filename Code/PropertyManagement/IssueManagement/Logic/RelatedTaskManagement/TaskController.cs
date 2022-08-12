using REM.Logic.RealEstateManagement.PropertyManagement.IssueManagement.Models;
using System;
using System.Collections.Generic;

public class TaskController : ITaskController 
{
    #region public methods
    public Guid Create(Guid issueId, ICollection<Task> tasks) {
		return new Guid();
	}
	public void Change() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Delete() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void Review() {
		throw new System.NotImplementedException("Not implemented");
	}
    #endregion
}
