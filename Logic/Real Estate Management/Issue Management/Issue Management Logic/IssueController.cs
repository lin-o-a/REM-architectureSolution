using System;

public class IssueController : IIssueController  {
	#region private methods
	//private readonly IIssueCreationService issueCreationService;
	#endregion

    #region public methods
	public void Create(IssueChangeService issue) {
		//add issue
		//var issueId = issueCreationService.Create(issue);
		//Check if issue was created by requesting new issue id from a database

		//add issue documents
		//Check if issue documents were added by requesting each added document id from a database
	}
	public void Change() {
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
