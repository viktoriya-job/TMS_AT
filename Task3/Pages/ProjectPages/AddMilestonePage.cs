using OpenQA.Selenium;
using Task3.Elements;
using Task3.Pages;

namespace Task3.Pages.ProjectPages;

public class AddMilestonePage : ProjectBasePage
{
    private static readonly By _nameInputBy = By.Id("name");
    private static readonly By _referenceInputBy = By.Id("reference");
    private static readonly By _parentDropDownBy = By.Id("show_announcement");
    private static readonly By _descriptionInputBy = By.Id("description_display");
    private static readonly By _startDateBy = By.Id("start_on");
    private static readonly By _endDateBy = By.Id("is_completed");
    private static readonly By _isCompletedBy = By.Id("due_on");
    private static readonly By _addButtonBy = By.Id("accept");

    public AddMilestonePage(IWebDriver driver) : base(driver) { }

    protected override string GetEndpoint() => throw new NotImplementedException();
    public override bool IsPageOpened() => throw new NotImplementedException();

    public UIElement NameInput => new(Driver, _nameInputBy);
    public UIElement ReferenceInput => new(Driver, _referenceInputBy);
    public DropDownMenu ParentDropDown => new(Driver, _parentDropDownBy);
    public UIElement DescriptionInput => new(Driver, _descriptionInputBy);
    public Calendar StartDate => new(Driver, _startDateBy);
    public Calendar EndDate => new(Driver, _endDateBy);
    public Checkbox IsCompleted => new(Driver, _isCompletedBy);
    public Button AddButton => new(Driver, _addButtonBy);

    public AddMilestonePage InputName(string name)
    {
        NameInput.SendKeys(name);
        return this;
    }

    public AddMilestonePage InputReference(string reference)
    {
        ReferenceInput.SendKeys(reference);
        return this;
    }

    public AddMilestonePage ChooseParent(int index)
    {
        ParentDropDown.SelectByIndex(index);
        return this;
    }

    public AddMilestonePage InputDescription(string description)
    {
        DescriptionInput.SendKeys(description);
        return this;
    }

    public AddMilestonePage ChooseStartDate(int day)
    {
        StartDate.SelectDay(day);
        return this;
    }

    public AddMilestonePage ChooseEndDate(int day)
    {
        EndDate.SelectDay(day);
        return this;
    }

    public AddMilestonePage CheckIsCompleted(bool value)
    {
        IsCompleted.SetState(value);
        return this;
    }

    public ProjectMilestonesPage ClickAddButton()
    {
        AddButton.Click();
        return new ProjectMilestonesPage(Driver);
    }
}