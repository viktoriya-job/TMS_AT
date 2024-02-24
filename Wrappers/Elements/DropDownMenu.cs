using OpenQA.Selenium;

namespace Wrappers.Elements
{
    public class DropDownMenu
    {
        private UIElement _uiElement;
        private List<UIElement> _options;

        public DropDownMenu(IWebDriver webDriver, By by)
        {
            _uiElement = new UIElement(webDriver, by);
            _options = _uiElement.FindUIElements(By.CssSelector(".chzn-results>li"));
        }

        public UIElement SelectedOption
        {
            get
            {
                try
                {
                    return _uiElement.FindUIElement(By.ClassName("result-selected"));
                }
                catch
                {
                    throw new NoSuchElementException("No option is selected");
                }
            }
        }

        public bool Displayed => _uiElement.Displayed;

        public List<string> GetOptions()
        {
            var result = new List<string>();
            foreach (UIElement element in _options)
            {
                result.Add(element.Text);
            }
            return result;
        }

        public void SelectByText(string text)
        {
            bool flag = false;

            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("text", "text must not be null");
            }

            foreach (UIElement option in _options)
            {
                if (option.Text.Trim() == text)
                {
                    SelectOption(option);
                    flag = true;
                    return;
                }
            }
                if (!flag)
                {
                    throw new NoSuchElementException("Cannot locate element with text: " + text);
                }
        }

        public void SelectByIndex(int index)
        {
            if (index < _options.Count)
            {
                SelectOption(_options[index]);
            }
            else
            {
                throw new AssertionException("Cannot locate option with index: " + index);
            }
        }

        private void SelectOption(UIElement option)
        {
            _uiElement.Click();
            option.Click();
        }
    }
}
