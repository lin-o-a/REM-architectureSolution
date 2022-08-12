using SimpleInjector;

namespace REM.Logic.CoreManagement.Dependency_Injection
{
    public class DependencyCompositionRoot
    {
        public Container SetUpDIMechanism() {
            var container = new Container();
            container.Register<IIssueController, IssueController>();
            
            container.Register<ITaskController, TaskController>();
            container.Register<IIssueCreationService, IssueCreationService>();
            container.Register<ICheckPointService, CheckPointService>();

            container.Verify();

            return container;
        }
    }
}
