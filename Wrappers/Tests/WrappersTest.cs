using OpenQA.Selenium;
using Wrappers.Elements;
using Wrappers.Pages.Administration;
using Wrappers.Pages.ProjectPages;


namespace Wrappers.Tests
{
    public class WrappersTest : BaseTest
    {
        [Test]
        public void CheckboxTest()
        {
            UserSteps
                .SuccessfulLogin()
                .AddProjectButton.Click();

            AddProjectPage addProjectPage = new AddProjectPage(Driver);

            addProjectPage.ShowAnnouncementCheckbox.SetState(true);
            Assert.That(addProjectPage.ShowAnnouncementCheckbox.IsChecked);
        }

        [Test]
        public void DropDownTest()
        {
            UserSteps
                .SuccessfulLogin();

        AddTestCasePage addTestCasePage = new AddTestCasePage(Driver, true);

        //    Thread.Sleep(5000);
        }
    }
}