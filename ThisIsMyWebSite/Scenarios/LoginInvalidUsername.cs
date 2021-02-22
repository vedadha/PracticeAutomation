
using NUnit.Framework;
using OpenQA.Selenium;
using ThisIsMyWebSite.Pages;

namespace ThisIsMyWebSite.Scenarios
{
    [Parallelizable]
    public class LoginInvalidUsername
    {
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void InitializeDriver()
        {
            Driver = Actionss.InitializeDriver();
        }

        [Test]
        public void PassRandomEmail()
        {
            UtilityNavigation utNav = new UtilityNavigation(Driver);
            AuthenticationPage atPage = new AuthenticationPage(Driver);

            utNav.ClickSignIn();
            atPage.Login(Config.Credidentials.Invalid.invalidEmail, Config.Credidentials.Valid.password);

        }

        [TearDown]
        public void ClearAll()
        {
            Driver.Quit();
        }

    }
}
