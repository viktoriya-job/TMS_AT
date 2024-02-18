using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrappers.Pages.Heroku
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}