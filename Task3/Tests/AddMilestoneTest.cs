using Task3.Steps;
using Task3.Pages;
using Task3.Models;
using Task3.Elements;
using OpenQA.Selenium;

namespace Task3.Tests
{
    public class AddMilestoneTest : BaseTest
    {
        [Test]
        public void SuccessAddMilestoneTestByBuilder()
        {
            Random random = new Random();
            NavigationSteps.SuccessfulLogin(Admin);

            ProjectsPage projectsPage = new ProjectsPage(Driver, true);

            TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "FeedTheCatProject", "Project");
            tableCell.GetOverviewLink().Click();

            Milestone milestone = new Milestone.Builder()
                .SetName($"FeedTheCatProjectMilestone_{random.Next(1000)}")
                .SetReferences($"Reference_{random.Next(10)}")
                .SetDescription($"Description_{random.Next(1000)}")
                .SetStartDate(random.Next(1, 10))
                .SetEndDate(random.Next(10, 28))
                .SetIsMilestoneCompleted(random.Next(0, 1) == 1)
                .Build();

            ProjectsSteps.AddMilestone(milestone);

            Assert.That(WaitsHelper.WaitForExists(By.XPath($"//*[text()='{milestone.Name}']")).Enabled);
        }
    }
}