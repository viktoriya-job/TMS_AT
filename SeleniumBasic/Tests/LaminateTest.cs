using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;

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
            IWebElement layingInput = Driver.FindElement(By.CssSelector("label[for=direction-laminate-id3]"));
            SelectElement layingSelect = new SelectElement(Driver.FindElement(By.Id("laying_method_laminate")));
            IWebElement minLength = Driver.FindElement(By.Id("min_length_segment_id"));
            IWebElement indexWalls = Driver.FindElement(By.Id("indent_walls_id"));
            IWebElement button = Driver.FindElement(By.Id("btn_calculate"));

            int minLengthValueLength = minLength.GetAttribute("value").Length;
            int indexWallsValueLength = indexWalls.GetAttribute("value").Length;

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
            layingSelect.SelectByValue("2");

            for (int i = 0; i < minLengthValueLength; i++)
                minLength.SendKeys(Keys.Backspace);

            minLength.SendKeys("300");

            for (int i = 0; i < indexWallsValueLength; i++)
                indexWalls.SendKeys(Keys.Backspace);

            indexWalls.SendKeys("8");

            button.Click();

            Thread.Sleep(5000);
            IWebElement result = Driver.FindElement(By.CssSelector(".calc-result"));

            Assert.That(new Regex(@"\r").Replace(result.Text, ""), Is.EqualTo("Требуемое количество плашек ламината: 63\nКоличество упаковок ламината: 4\nСтоимость ламината: 0 руб\nВес ламината: 0 кг"));
        }
    }
}