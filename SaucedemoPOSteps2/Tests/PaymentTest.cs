﻿using SaucedemoPOSteps.Pages;
using SaucedemoPOSteps.Helpers.Configuration;

namespace SaucedemoPOSteps.Tests
{
    public class PaymentTest : BaseTest
    {
        //[Test]
        //[Order(6)]
        //[Category("PositiveTest")]
        //[Category("PaymentTest")]
        //[Description("Проверка успешной оплаты - без предварительной проверки списка товаров и суммы")]
        //public void PaymentSimpleTest()
        //{
        //    LoginPage loginPage = new LoginPage(Driver, true);
        //    InventoryPage inventoryPage = loginPage.SuccessLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        //    inventoryPage.BikeLiteItemSmall.AddItem();
        //    inventoryPage.BackpackItemSmall.AddItem();

        //    CartPage cartPage = new CartPage(Driver, true);
        //    CheckoutStepOnePage checkoutStepOnePage = cartPage.Checkout();
        //    CheckoutStepTwoPage checkoutStepTwoPage = checkoutStepOnePage.Continue();
        //    ThankYouPage thankYouPage = checkoutStepTwoPage.Finish();

        //    Assert.That(thankYouPage.IsPageOpened());
        //}
    }
}