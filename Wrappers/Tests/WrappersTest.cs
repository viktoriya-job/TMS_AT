using Wrappers.Elements.HerokuappTable;
using Wrappers.Pages.HerokuappPages;
using Wrappers.Pages.LaminatePages;
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

            addTestCasePage.SectionDropDown.SelectByIndex(0);
            addTestCasePage.TemplateDropDown.SelectByText("Test Case (Steps)");
            Thread.Sleep(2000); //не до конца победила 'stale element not found' >=O  Часть кода, где пыталась победить, закомментировала
            addTestCasePage.TypeDropDown.SelectByText("Accessibility");
            addTestCasePage.PriorityDropDown.SelectByText("Low");
            addTestCasePage.AssignedToDropDown.SelectByText("Me");
            addTestCasePage.AutomationTypeDropDown.SelectByText("Ranorex");

            Assert.Multiple(() =>
            {
                Assert.That(addTestCasePage.SectionDropDown.SelectedOption.Text.Trim(), Is.EqualTo("Test Cases"));
                Assert.That(addTestCasePage.TypeDropDown.SelectedOption.Text.Trim(), Is.EqualTo("Accessibility"));
                Assert.That(addTestCasePage.PriorityDropDown.SelectedOption.Text.Trim(), Is.EqualTo("Low"));
                Assert.That(addTestCasePage.AssignedToDropDown.SelectedOption.Text.Trim(), Is.EqualTo("Me"));
                Assert.That(addTestCasePage.AutomationTypeDropDown.SelectedOption.Text.Trim(), Is.EqualTo("Ranorex"));
                Assert.That(addTestCasePage.TemplateDropDown.SelectedOption.Text.Trim(), Is.EqualTo("Test Case (Steps)"));
            });
        }

        [Test]
        public void CalcLaminateTest()
        {
            LaminateMainPage laminateMainPage = new LaminateMainPage(Driver);

            Assert.Multiple(() =>
            {
                laminateMainPage.RadioButtonLaminate.SelectByValue("1");
                Assert.That(laminateMainPage.RadioButtonLaminate.SelectedOptionText == "Укладка по ширине 90°");

                laminateMainPage.RadioButtonLaminate.SelectByText("Укладка по диагонали 135°");
                Assert.That(laminateMainPage.RadioButtonLaminate.SelectedOptionText == "Укладка по диагонали 135°");

                laminateMainPage.RadioButtonLaminate.SelectByIndex(0);
                Assert.That(laminateMainPage.RadioButtonLaminate.SelectedOptionText == "Укладка по длине 0°");
            });
        }

        [Test]
        public void TableTest()
        {
            HerokuappTablesPage herokuappTablesPage = new HerokuappTablesPage(Driver, true);

            herokuappTablesPage.TableExample1.EditRow("Email", "jdoe@hotmail.com");
            herokuappTablesPage.TableExample1.DeleteRow("First Name", "John");
        }
    }
}