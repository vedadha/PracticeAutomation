
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using ThisIsMyWebSite.Pages;

namespace ThisIsMyWebSite.TestCases
{
    [Parallelizable]

    public class CreateAccount
    {
        public IWebDriver Driver { get; set; }

        IAlert alert;

        [SetUp]
        public void InitializeDriver()
        {
            Driver = Actionss.InitializeDriver();
        }

        [Test]
        public void CreateAccountMethod()
        {
            UtilityNavigation utNav = new UtilityNavigation(Driver);
            AuthenticationPage authenPage = new AuthenticationPage(Driver);
            CreateAnAccount createAccount = new CreateAnAccount(Driver);

            utNav.ClickSignIn();
            string email = "example" + DateTime.Now.ToString("yyyyMMddHHmmss") + "@example.com";
            authenPage.CreateAccount(email);
            createAccount.PopulateAccountInfo();
        }

        [TearDown]
        public void ClearAll()
        {
            Driver.Quit();
        }
    }


}
