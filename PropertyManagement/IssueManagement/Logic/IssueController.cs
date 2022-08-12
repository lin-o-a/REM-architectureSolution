using REM.Logic.RealEstateManagement.PropertyManagement.IssueManagement.Models;
using System;

public class IssueController : IIssueController {
	#region private properties
	private readonly IIssueCreationService _issueCreationService;
	private readonly ITaskController _taskController;
	#endregion

	#region constructor
	public IssueController(IIssueCreationService issueCreationService, 
			ITaskController taskController) {
		_issueCreationService = issueCreationService;
		_taskController = taskController;
	}
	#endregion

	#region private methods
	private bool AddTasksToIssue(Issue issue) {
		var addedTasksId = _taskController.Create(issue.Id, issue.Tasks);
		return addedTasksId != Guid.Empty;
	}
	#endregion

	#region public methods
	public bool Create(Issue issue) {
		var isIssueCreated = _issueCreationService.Create(issue);
		
		var isTaskAddedToIssue = false;
		if (isIssueCreated)
			isTaskAddedToIssue = AddTasksToIssue(issue);

		var isIssueCreatedSuccessfully = isIssueCreated && isTaskAddedToIssue;
		return isIssueCreatedSuccessfully;
	}

	public void Change(Issue issue) {
		//if-else for what do we change: issue specification or its state or its documents or its tasks
	}
	public void Delete() {
		//delete issue tasks and their documents
		//Check if they were successfully deleted

		//delete documents
		//Check if issue was created by requesting new issue id from a database

		//delete issue
		//Check if it was successfully deleted
	}
	public void Send() {
	}
   #endregion
}
