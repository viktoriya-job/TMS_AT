using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Wrappers.Elements;
using Wrappers.Helpers.Configuration;
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

            AddTestCasePage addTestCasePage = new AddTestCasePage(Driver, true);

            Thread.Sleep(2000);

            Assert.That(addTestCasePage.PageTitle.Text.Trim(), Is.EqualTo("Add Test Case"));
            Assert.That(addTestCasePage.TemplateDropDown.Displayed);
            addTestCasePage.TemplateDropDown.SelectByIndex(0);

            addTestCasePage.TemplateDropDown.SelectByText("");

            Console.WriteLine(addTestCasePage.SectionDropDown.SelectedOption.Text);
            Console.WriteLine(addTestCasePage.TemplateDropDown.SelectedOption.Text);
        }
    }
}
