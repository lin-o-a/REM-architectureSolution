using System;

public class IssueController : IIssueController  {
	#region private attributes
	private readonly IIssueCreationService _issueCreationService;
	#endregion

	#region constructor
	public IssueController(IIssueCreationService issueCreationService) {
		this._issueCreationService = issueCreationService;
	}
	#endregion

	#region public methods
	public void Create(Issue issue) {
		//add issue
		//var issueId = issueCreationService.Create(issue);
		//Check if issue was created by requesting new issue id from a database

		//add issue documents
		//Check if issue documents were added by requesting each added document id from a database
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
	private void Send() {
	}
   #endregion
}
