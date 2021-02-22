
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using ThisIsMyWebSite.Pages;

namespace ThisIsMyWebSite.TestCases
{
    [Parallelizable]

    public class CheckOut
    {
        public IWebDriver Driver { get; set; }
        IAlert alert;

        [SetUp]
        public void InitializeDriver()
        {
            Driver = Actionss.InitializeDriver();
        }

        [Test]
        public void CheckOutFunctionality()
        {
            UtilityNavigation utNav = new UtilityNavigation(Driver);
            AuthenticationPage atPage = new AuthenticationPage(Driver);
            MainNavigation mainNav = new MainNavigation(Driver);
            BlousesPage blousesPage = new BlousesPage(Driver);
            ProductPage prodPage = new ProductPage(Driver);
            YourShoppingCart scPage = new YourShoppingCart(Driver);
            MyAddressPage myAddress = new MyAddressPage(Driver);
            ShippingPage shipPage = new ShippingPage(Driver);
            YourPaymentPage tpPage = new YourPaymentPage(Driver);
            BankWirePayment bwPayment = new BankWirePayment(Driver);

            //Navigate to Login page
            utNav.ClickSignIn();
            //Login
            atPage.Login(Config.Credidentials.Valid.userName, Config.Credidentials.Valid.password);

            //Main navigation
            mainNav.HoverWoman(Driver);
            mainNav.ClickBlouses(Driver);
            //Blouses page
            blousesPage.ClickOnProduct();
            //Product page
            prodPage.ClickAddToCart();
            prodPage.Process();
            //YourShoppingCart page
            scPage.QuantityFunc();
            scPage.ProceedToCart();
            //MyAddress page
            myAddress.ProceedToCheckOut();
            //Shipping page
            shipPage.IAgreeCheckBox();
            shipPage.ProceedCheckOut();
            //YourPayment page
            tpPage.BankWire();
            //Bank Wire Page
            bwPayment.ClickIConfirmOrder();
        }

        [TearDown]
        public void ClearAll()
        {
            Driver.Quit();
        }
    }


}
