using OpenQA.Selenium;

namespace Wrappers.Elements.HerokuappTable
{
    public class HTableCell
    {
        private UIElement _uiElement;

        public HTableCell(UIElement uiElement)
        {
            _uiElement = uiElement;
        }

        public string Text => _uiElement.Text;

        public UIElement GetEditLink() => _uiElement.FindUIElement(By.XPath("a[text()='edit']"));
        public UIElement GetDeleteLink() => _uiElement.FindUIElement(By.XPath("a[text()='delete']"));
    }
}