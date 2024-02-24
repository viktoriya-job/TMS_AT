using OpenQA.Selenium;

namespace Wrappers.Elements;

public class Checkbox
{
    private UIElement _uiElement;

    public Checkbox(IWebDriver webDriver, By by)
    {
        _uiElement = new UIElement(webDriver, by);
    }
    public Checkbox(IWebDriver webDriver, IWebElement webElement)
    {
        _uiElement = new UIElement(webDriver, webElement);
    }

    public bool Displayed => _uiElement.Displayed;

    public void Click()
    {

    }
}