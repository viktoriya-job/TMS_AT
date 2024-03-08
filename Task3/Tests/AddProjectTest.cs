using Task3.Steps;
using Task3.Pages;
using Task3.Models;

namespace Task3.Tests
{
    public class AddProjectTest : BaseTest
    {
        [Test]
        public void SuccessAddProjectTest()
        {
            Random random = new Random();
            Project project = new Project
            {
                ProjectName = $"FeedTheCatProject_{random.Next(1000)}",
                Announcement = $"TestProjectAnnouncemen_{random.Next(1000)}",
                IsShowAnnouncement = random.Next(0, 1) == 0,
                ProjectType = random.Next(0, 2),
                IsTestCaseApprovals = random.Next(0, 1) == 1
            };

            NavigationSteps.SuccessfulLogin(Admin);

            ProjectsPage projectsPage = ProjectSteps.AddProject(project);

            Assert.That(projectsPage.ProjectsTable.GetCell("Project", project.ProjectName, 0).GetLink().Enabled);
        }
    }
}
