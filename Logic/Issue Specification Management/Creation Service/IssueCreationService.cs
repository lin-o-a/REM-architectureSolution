using System;

internal class IssueCreationService : IIssueCreationService
{
    #region private methods
    //private readonly IDatabaseController databaseController;
    #endregion

    #region private 
    private bool CheckIssue(Issue issue)
    {
        return true;
    }
    #endregion

    #region public
    public Guid Create(Issue issue)
    {
        var id = new Guid();
        //Check if issue is not empty object
        //Check if name and description are not empty and have values obeyed to BR1, BR2
        //var hasCorrectValues = CheckIssue(issue);.

        //id = CreateIssue();

        return id;
    }
    #endregion
}