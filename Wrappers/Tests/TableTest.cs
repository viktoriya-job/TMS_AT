using OpenQA.Selenium;
using Wrappers.Elements;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages.Administration;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Tests;

public class TableTest : BaseTest
{
    [Test]
    public void AddProjectCorrectTest()
    {
        UserSteps
            .SuccessfulLogin();

        ProjectsPage projectsPage = new ProjectsPage(Driver, true);

        TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "asd", "Project");
        Console.WriteLine(tableCell.GetLink().GetAttribute("href"));
        Console.WriteLine(tableCell.GetOverviewLink().GetAttribute("href"));

        tableCell.GetOverviewLink().Click();
    }
}