﻿using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace PageObjectStepsSauceDemo.Pages.ItemsSmall
{
    public class SauceLabsOnesieItemSmall : BasePage
    {
        private static readonly By _itemTitleBy = By.XPath("//div[text()='Sauce Labs Onesie']");
        private static readonly By _addButtonBy = By.Id("add-to-cart-sauce-labs-onesie");
        private static readonly By _removeButtonBy = By.Id("remove-sauce-labs-onesie");

        public SauceLabsOnesieItemSmall(IWebDriver driver) : base(driver) { }

        public IWebElement ItemTitle => WaitsHelper.WaitForExists(_itemTitleBy);
        public IWebElement AddButton => WaitsHelper.WaitForExists(_addButtonBy);
        public IWebElement RemoveButton => WaitsHelper.WaitForExists(_removeButtonBy);

        public bool IsItemAddedToCart() => RemoveButton.Enabled;
        public bool IsItemNotAddedToCart() => AddButton.Enabled;

        [AllureStep("Add item")]
        public void AddItem() => AddButton.Click();

        [AllureStep("Remove Item")]
        public void RemoveItem() => RemoveButton.Click();

        public override bool IsPageOpened() => ItemTitle.Displayed;

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}
