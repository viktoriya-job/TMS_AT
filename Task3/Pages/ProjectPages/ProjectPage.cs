using OpenQA.Selenium;
using Task3.Elements;

namespace Task3.Pages.ProjectPages
{
    public class ProjectPage : ProjectBasePage
    {
        private static readonly By _addMilestoneButtonBy = By.Id("navigation-overview-addmilestones");

        public ProjectPage(IWebDriver driver) : base(driver) { }

        protected override string GetEndpoint() => throw new NotImplementedException();
        public override bool IsPageOpened() => throw new NotImplementedException();

        public Button AddMilestoneButton => new(Driver, _addMilestoneButtonBy);

        public AddMilestonePage ClickAddMilestoneButton()
        {
            AddMilestoneButton.Click();
            return new AddMilestonePage(Driver);
        }
    }
}