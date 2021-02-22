
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using ThisIsMyWebSite.Pages;

namespace ThisIsMyWebSite.TestCases
{
    [Parallelizable]

    public class AddToCart
    {
        public IWebDriver Driver { get; set; }
        IAlert alert;

        [SetUp]
        public void InitializeDriver()
        {
            Driver = Actionss.InitializeDriver();
        }

        [Test]
        public void AddBlousesToChart()
        {
            UtilityNavigation utNav = new UtilityNavigation(Driver);
            AuthenticationPage atPage = new AuthenticationPage(Driver);
            MainNavigation mainNav = new MainNavigation(Driver);
            BlousesPage blousesPage = new BlousesPage(Driver);
            ProductPage prodPage = new ProductPage(Driver);
            
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
            prodPage.ClickOnPhoto();
            prodPage.ClickNextPhoto();
            prodPage.ClickPreviousPhoto();
            prodPage.ClosePhoto();
            prodPage.QuantitiyFunc();
            prodPage.ChangeSize();
            prodPage.ChangeColor();
            prodPage.AddWishlist();
            prodPage.ClickAddToCart();
        }

        [TearDown]
        public void ClearAll()
        {
            Driver.Quit();
        }
    }


}
