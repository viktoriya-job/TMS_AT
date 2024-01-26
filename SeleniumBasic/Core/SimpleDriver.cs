
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Reflection;

namespace SeleniumBasic.Core
{
    public class SimpleDriver
    {
        public IWebDriver Driver
        {
            get
            {
                var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

                return new ChromeDriver(basePath + @"/Resources/");
            }
        }
    }
}
