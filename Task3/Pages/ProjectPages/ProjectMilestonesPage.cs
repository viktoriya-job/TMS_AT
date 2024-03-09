using OpenQA.Selenium;
using Task3.Elements;

namespace Task3.Pages.ProjectPages
{
    public class ProjectMilestonesPage : BasePage
    {
        public ProjectMilestonesPage(IWebDriver driver) : base(driver) { }

        public override bool IsPageOpened() => throw new NotImplementedException();
        protected override string GetEndpoint() => throw new NotImplementedException();
    }
}