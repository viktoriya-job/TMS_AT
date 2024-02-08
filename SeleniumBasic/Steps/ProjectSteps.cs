using OpenQA.Selenium;
using PageObjectSimple.Pages;

namespace PageObjectSimple.Steps
{
    public class ProjectSteps : BaseSteps
    {
        public ProjectSteps(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToAddProjectPage()
        {
            new AddProjectPage(Driver, true);
        }
    }
}