﻿using OpenQA.Selenium;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAdvanced.Helpers
{
    public class WaitsHelper(IWebDriver driver, TimeSpan timeout)
    {
        private readonly WebDriverWait _wait = new WebDriverWait(driver, timeout);

        public IWebElement WaitForVisibilityLocatedBy(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement WaitForExists(By locator)
        {
            return _wait.Until(ExpectedConditions.ElementExists(locator));
        }

        public bool WaitForElementInvisible(By locator)
        {
            return _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public bool WaitForElementInvisible(IWebElement element)
        {
            try
            {
                // Проверка, видим ли элемент
                return _wait.Until(d => !element.Displayed);
            }
            catch (NoSuchElementException)
            {
                // Если элемент не найден, считаем его невидимым
                return true;
            }
            catch (StaleElementReferenceException)
            {
                // Если элемент устарел, считаем его невидимым
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                // Если время истекло, можно сделать что-то в этом случае, например, вывести сообщение об ошибке
                throw new WebDriverTimeoutException("Элемент не стал невидимым в течение заданного времени");
            }
        }

        public ReadOnlyCollection<IWebElement> WaitForAllVisibleElementsLocatedBy(By locator)
        {
            return _wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }

        public bool WaitForVisibility(IWebElement element)
        {
            return _wait.Until(_ => element.Displayed);
        }

        public IWebElement FluentWait(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
            {
                PollingInterval = TimeSpan.FromMilliseconds(50),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            return wait.Until(d => driver.FindElement(locator));
        }

        public bool Wait(string path, TimeSpan timeout)
        {
            TimeSpan polling = TimeSpan.FromMilliseconds(200);
            IClock clock = new SystemClock();
            DateTime otherDateTime = clock.LaterBy(timeout);

            while (true)
            {
                if (File.Exists(path))
                {
                    return true;
                }

                if (!clock.IsNowBefore(otherDateTime))
                {
                    throw new TimeoutException();
                }

                Thread.Sleep(polling);
            }
        }
    }
}