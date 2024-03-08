using OpenQA.Selenium;
using Task2.Elements;

namespace Task2.Pages.ProjectPages;

public class AddProjectPage : ProjectBasePage
{
    private static string END_POINT = "index.php?/admin/projects/add";

    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _announcemenInputBy = By.Id("announcement_display");
    private static readonly By _showAnnouncemenCheckboxBy = By.Id("show_announcement");
    private static readonly By _suiteModeRadioBy = By.Name("suite_mode");
    private static readonly By _caseStatusesEnabledCheckboxBy = By.Id("case_statuses_enabled");
    private static readonly By _addButtonBy = By.Id("accept");

    public AddProjectPage(IWebDriver driver) : base(driver) { }
    public AddProjectPage(IWebDriver driver, bool openByUrl) : base(driver, openByUrl) { }

    protected override string GetEndpoint() => END_POINT;
    public override bool IsPageOpened() => throw new NotImplementedException();

    public UIElement NameInput => new(Driver, _nameInputBy);
    public UIElement AnnouncemenInput => new(Driver, _announcemenInputBy);
    public Checkbox ShowAnnouncemenCheckbox => new(Driver, _showAnnouncemenCheckboxBy);
    public RadioButton SuiteModeRadio => new(Driver, _suiteModeRadioBy);
    public Checkbox CaseStatusesEnabledCheckbox => new(Driver, _caseStatusesEnabledCheckboxBy);
    public Button AddButton => new(Driver, _addButtonBy);

    public AddProjectPage InputNameValue(string value)
    {
        NameInput.SendKeys(value);
        return this;
    }

    public AddProjectPage InputAnnouncemenValue(string value)
    {
        AnnouncemenInput.SendKeys(value);
        return this;
    }

    public AddProjectPage CheckShowAnnouncemenCheckbox(bool value)
    {
        ShowAnnouncemenCheckbox.SetState(value);
        return this;
    }

    public AddProjectPage ChooseSuiteModeRadio(string value)
    {
        SuiteModeRadio.SelectByText(value);
        return this;
    }

    public AddProjectPage CheckCaseStatusesEnabledCheckbox(bool value)
    {
        CaseStatusesEnabledCheckbox.SetState(value);
        return this;
    }

    public ProjectsPage ClickAddButton()
    {
        AddButton.Click();
        return new ProjectsPage(Driver);
    }
}