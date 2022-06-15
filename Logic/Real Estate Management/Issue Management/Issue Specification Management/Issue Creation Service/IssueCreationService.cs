using System;

internal class IssueCreationService : IIssueCreationService  {
    #region private 
    private bool CheckIssue(Issue issue)
    {
        return true;
    }
    #endregion

    #region public
    public void Create(Issue issue) {
        var hasCorrectValues = CheckIssue(issue);
	}
    #endregion
}
