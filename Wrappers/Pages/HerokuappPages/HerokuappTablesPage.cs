using OpenQA.Selenium;
using Wrappers.Elements.HerokuappTable;

namespace Wrappers.Pages.HerokuappPages
{
    public class HerokuappTablesPage : BasePage
    {
        private static string END_POINT = "/tables";

        private static readonly By TableExample1By = By.Id("table1");

        public HerokuappTablesPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public HTable TableExample1 => new(Driver, TableExample1By);

        protected override string GetEndpoint() => END_POINT;

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }
    }
}