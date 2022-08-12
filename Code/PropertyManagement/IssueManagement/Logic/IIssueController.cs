using REM.Logic.CoreManagement.SystemController;
using System;

public interface IIssueController {
    void Change(Issue issue);
    bool Create(Issue issue);
}
