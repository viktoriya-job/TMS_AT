using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests
{
    public class LaminateTest : BaseTest
    {
        [Test]
        public void CalcLaminateTest()
        {
            Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

            IWebElement lnRoomInput = Driver.FindElement(By.Id("ln_room_id"));
            IWebElement wdRoomInput = Driver.FindElement(By.Id("wd_room_id"));
            IWebElement lnLamInput = Driver.FindElement(By.Id("ln_lam_id"));
            IWebElement wdLamID = Driver.FindElement(By.Id("wd_lam_id"));
            IWebElement packInput = Driver.FindElement(By.Id("n_packing"));
            IWebElement areaInput = Driver.FindElement(By.Id("area"));
            IWebElement layingInput = Driver.FindElement(By.CssSelector("label[for=direction-laminate-id2]"));
            SelectElement layingSelect = new SelectElement(Driver.FindElement(By.Id("laying_method_laminate")));
            IWebElement button = Driver.FindElement(By.Id("btn_calculate"));

            lnRoomInput.Clear();
            lnRoomInput.SendKeys("320");

            wdRoomInput.Clear();
            wdRoomInput.SendKeys("280");

            lnLamInput.Clear();
            lnLamInput.SendKeys("900");

            wdLamID.Clear();
            wdLamID.SendKeys("180");

            packInput.Clear();
            packInput.SendKeys("20");

            areaInput.SendKeys("1.8");

            layingInput.Click();
            layingSelect.SelectByValue("0");
            button.Click();

            Thread.Sleep(2000);
            IWebElement result = Driver.FindElement(By.CssSelector(".calc-result"));
            Assert.That(result.Text, Is.EqualTo("Требуемое количество плашек ламината: 65\r\nКоличество упаковок ламината: 4\r\nСтоимость ламината: 0 руб\r\nВес ламината: 0 кг"));
        }
    }
}
