using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Wrappers.Elements;

namespace Wrappers.Pages.ProjectPages
{
    public class AddTestCasePage : BasePage
    {
        private static string END_POINT = "index.php?/cases/add/1";

        private static readonly By PageTitleBy = By.ClassName("page_title");
        private static readonly By SectionDropDownBy = By.Id("section_id_chzn");
        private static readonly By TemplateDropDownBy = By.Id("template_id_chzn");


        public AddTestCasePage(IWebDriver driver) : base(driver) { }
        public AddTestCasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl) { }

        public UIElement PageTitle => new(Driver, PageTitleBy);
        public DropDownMenu SectionDropDown => new DropDownMenu(Driver, SectionDropDownBy);
        public DropDownMenu TemplateDropDown => new DropDownMenu(Driver, TemplateDropDownBy);


        public UIElement TestElement => new(Driver, By.Id("template_id_chzn_o_0"));

        protected override string GetEndpoint() => END_POINT;

        public override bool IsPageOpened()
        {
            try
            {
                return PageTitle.Text.Trim() == "Products";
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}