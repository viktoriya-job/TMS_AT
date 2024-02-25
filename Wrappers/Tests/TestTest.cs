using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Wrappers.Elements;
using Wrappers.Helpers.Configuration;
using Wrappers.Pages.Administration;
using Wrappers.Pages.ProjectPages;


namespace Wrappers.Tests
{
    public class TestTest : BaseTest
    {
        [Test]
        public void Test()
        {
            UserSteps
                .SuccessfulLogin();

            ProjectsPage projectsPage = new ProjectsPage(Driver, true);

            //TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "asd", "Project");

            //foreach(string el in projectsPage.ProjectsTable.GetValues("Project"))
            //{
            //    Console.WriteLine(el);
            //}

            //TableCell tableCell = 
            //    projectsPage.ProjectsTable
            //    .GetRow("Project", "YTest")
            //    .GetCell(2);

            TableCell tableCell =
                projectsPage.ProjectsTable
                .GetCell("Project", "YTest", 2);

            tableCell.GetLink().Click();

            Thread.Sleep(2000);


            //AddTestCasePage addTestCasePage = new AddTestCasePage(Driver, true);
            //Console.WriteLine(addTestCasePage.TypeDropDown.DropElement.GetCssValue("display"));
            //Console.WriteLine(addTestCasePage.TypeDropDown.DropDownMenuDisplayed);

            //addTestCasePage.TypeDropDown.Click();
            //Console.WriteLine(addTestCasePage.TypeDropDown.DropDownMenuDisplayed);
            //Console.WriteLine(addTestCasePage.TypeDropDown.DropElement.GetCssValue("display"));
        }
    }
}
