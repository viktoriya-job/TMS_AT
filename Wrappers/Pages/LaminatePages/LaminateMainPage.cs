using OpenQA.Selenium;
using Wrappers.Elements;

namespace Wrappers.Pages.LaminatePages
{
    public class LaminateMainPage : BasePage
    {
        private static readonly By radioButtonLaminateBy = By.Name("direction-laminate");

        public LaminateMainPage(IWebDriver driver) : base(driver) { }

        public RadioButtonLaminate RadioButtonLaminate => new(Driver, radioButtonLaminateBy);

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}