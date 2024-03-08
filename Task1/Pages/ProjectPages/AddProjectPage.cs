using ChainOfInvocations.Elements;
using OpenQA.Selenium;

namespace ChainOfInvocations.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    private static readonly By _addButtonBy = By.Id("accept");
    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _announcemenInputBy = By.Id("announcement_display");
    private static readonly By _showAnnouncemenCheckboxBy = By.Id("show_announcement");
    private static readonly By _suiteModeRadioBy = By.Name("suite_mode");
    private static readonly By _caseStatusesEnabledCheckboxBy = By.Id("case_statuses_enabled");


    public AddProjectPage(IWebDriver driver) : base(driver) { }
    public AddProjectPage(IWebDriver driver, bool openByUrl) : base(driver, openByUrl) { }

    protected override string GetEndpoint() => END_POINT;

    public override bool IsPageOpened()
    {
        throw new NotImplementedException();
    }

    public Button AddButton => new(Driver, _addButtonBy);
    public Checkbox ShowAnnouncemenCheckbox => new(Driver, _addButtonBy);
}