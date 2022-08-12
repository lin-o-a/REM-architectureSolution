using LinqToDB;
using REM.Logic.CoreManagement.SystemErrorManagement.ErrorCollecting;
using REM.Logic.RealEstateManagement.PropertyManagement;
using System;

internal class IssueCreationService : IIssueCreationService
{
    #region private methods
    private readonly IErrorCollector _errorCollector;
    #endregion

    #region constructor
    public IssueCreationService(IErrorCollector errorCollector) => _errorCollector = errorCollector;
    #endregion

    #region private
    private bool HasInvalidIssue(Issue issue) {
        if (issue != null)
            return false;

        var hasNoIssueMessage = PropertyManagementResources.HasNoIssueMessage;
        _errorCollector.Collect(hasNoIssueMessage);

        return true;
    }
    private bool HasInvalidName(string name) {

        if (!string.IsNullOrEmpty(name))
            return false;

        var issueHasNoNameMessage = PropertyManagementResources.HasNoNameMessage;
        _errorCollector.Collect(issueHasNoNameMessage);

        return true;
    }

    private bool IsIssueInvalid(Issue issue) {
        return HasInvalidIssue(issue) || HasInvalidName(issue.Name);
    }

    private bool TryToCreate(Issue issue)
    {
        try {
            using (var db = new DatabaseController()) {
                db.Issues
                    .Value(i => i.Name, issue.Name)
                    .Value(i => i.Description, issue.Description)
                    .Insert();
            }
        } catch (Exception exception) {
            var exceptionMessage = issue.Id + " " + exception.Message;
            _errorCollector.Collect(exceptionMessage);

            return false;
        }

        return true;
    }
    #endregion

    #region public
    public bool Create(Issue issue) {
        var hasIssue = issue != null;
        if (!hasIssue)
            return false;
        
        var hasIssueIncorrectValues = IsIssueInvalid(issue);
        if (hasIssueIncorrectValues)
            return false;

        return TryToCreate(issue);
    }
    #endregion
}