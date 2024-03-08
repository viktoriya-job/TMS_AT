using ChainOfInvocations.Helpers.Configuration;
using ChainOfInvocations.Pages;
using ChainOfInvocations.Steps;

namespace ChainOfInvocations.Tests
{
    public class AddProjectTest : BaseTest
    {
        [Test]
        public void SuccessAddProjectTest()
        {
            ProjectsPage projectsPage = NavigationSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .ClickSidebarProjectsAddButton()
                .InputNameValue("FeedTheCatProject")
                .InputAnnouncemenValue("TestProjectAnnouncemen")
                .CheckShowAnnouncemenCheckbox(true)
                .ChooseSuiteModeRadio("Use a single repository for all cases (recommended)")
                .CheckCaseStatusesEnabledCheckbox(true)
                .ClickAddButton();

            Assert.That(projectsPage.ProjectsTable.GetCell("Project", "FeedTheCatProject", 0).GetLink().Enabled);
        }
    }
}
