using AngleSharp.Dom;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Elements
{
    public class DropDownMenu
    {
        private UIElement _uiElement;
        private List<UIElement> _options;
        private WebDriverWait _wait;
        private By _locator;
        private By _locatorOptions = By.CssSelector(".chzn-results>li");

        public DropDownMenu(IWebDriver webDriver, By locator)
        {
            _uiElement = new UIElement(webDriver, locator);
            _wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
            _options = _uiElement.FindUIElements(_locatorOptions);
            _locator = locator;
        }

        public bool Displayed => _uiElement.Displayed;

        public bool DropDownMenuDisplayed
        {
            get
            {
                try
                {
                    return _uiElement.FindUIElement(By.ClassName("chzn-drop")).GetCssValue("display") == "block";
                }
                catch
                {
                    throw new NoSuchElementException("No elements 'drop' with value 'display' found");
                }
            }
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

        public string GetCssValue(string propertyName) => _uiElement.GetCssValue(propertyName);

        public void Click() => _uiElement.Click();

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
            //_uiElement.Click(() => _wait.Until(ExpectedConditions.ElementExists(Locator)));
            //_wait.Until(d => DropDownMenuDisplayed);
            option.Click();
            //option.Click(() => _wait.Until(ExpectedConditions.ElementExists(_locatorOptions)));
        }
    }
}