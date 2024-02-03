using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests
{
    public class FirstTest : BaseTest
    {
        [Test]
        public void ValidateIKTCalculationTest()
        {
            Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");
            IWebElement height = Driver.FindElement(By.Name("height"));
            IWebElement weight = Driver.FindElement(By.Name("weight"));
            IWebElement button = Driver.FindElement(By.Id("calc-mass-c"));

            height.SendKeys("183");
            weight.SendKeys("58");
            button.Click();

            Thread.Sleep(2000);
            IWebElement result = Driver.FindElement(By.Id("imt-result"));
            Assert.That(result.Text, Is.EqualTo("17.3 - Недостаточная (дефицит) масса тела"));
        }

        [Test]
        public void ValidateSKF()
        {
            Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
            //Driver.SwitchTo().Frame(0);
            Driver.SwitchTo().Frame(Driver.FindElement(By.CssSelector("[src='/scripts/gfr/?v=1']")));

            IWebElement ageInput = Driver.FindElement(By.Id("age"));
            SelectElement sexSelect = new SelectElement(Driver.FindElement(By.Id("sex")));
            IWebElement creatinineInput = Driver.FindElement(By.Id("cr"));
            SelectElement creatinineSelect = new SelectElement(Driver.FindElement(By.Id("cr-size")));
            SelectElement raceSelect = new SelectElement(Driver.FindElement(By.Id("race")));
            IWebElement massInput = Driver.FindElement(By.Id("mass"));
            IWebElement growInput = Driver.FindElement(By.Id("grow"));
            IWebElement button = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));

            ageInput.SendKeys("35");
            sexSelect.SelectByValue("F");
            creatinineInput.SendKeys("50");
            creatinineSelect.SelectByIndex(0);
            raceSelect.SelectByText("Другая");
            massInput.SendKeys("55");
            growInput.SendKeys("160");
            button.Click();

            Thread.Sleep(2000);

            IWebElement resultValue = Driver.FindElement(By.Id("mdrd_res"));
            Assert.That(resultValue.Text, Is.EqualTo("121.78"));

            IWebElement resultValue2 = Driver.FindElement(By.TagName("i"));
            Assert.That(resultValue2.Text, Is.EqualTo("мл/мин/1.73м2"));

            IWebElement resultDiagnosis = Driver.FindElement(By.ClassName("diagnosis"));
            Assert.That(resultDiagnosis.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));
        }
    }
}