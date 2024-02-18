using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.Heroku
{
    public class CheckboxesPage : BasePage
    {
        private static string _endPoint = "/checkboxes";
        //private static readonly By _checkbox1 = 
        public CheckboxesPage(IWebDriver driver) : base(driver)
        {
        }
        public CheckboxesPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint() => _endPoint;
    }
}