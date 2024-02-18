
using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.Heroku
{
    internal class AddRemovePage : BasePage
    {
        private static string _endPoint = "/add_remove_elements/";
        private static readonly By _addButtonBy = By.CssSelector(".example>button");
        public AddRemovePage(IWebDriver driver) : base(driver)
        {
        }

        public AddRemovePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public Button AddButton => new(Driver, _addButtonBy);
        public UIElement AddButton1 => new(Driver, _addButtonBy);

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint() => _endPoint;
    }
}