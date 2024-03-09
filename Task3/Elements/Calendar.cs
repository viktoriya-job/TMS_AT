
using OpenQA.Selenium;

namespace Task3.Elements
{
    public class Calendar
    {
        private UIElement _uiElement;

        public Calendar(IWebDriver webDriver, By locator)
        {
            _uiElement = new UIElement(webDriver, locator);
        }

        public bool Displayed => _uiElement.Displayed;

        public void Click() => _uiElement.Click();

        public void SelectDay(int value)
        {
            _uiElement.Click();
            _uiElement.FindUIElement(By.XPath($"//a[text()='{value}']")).Click();
        }
    }
}
