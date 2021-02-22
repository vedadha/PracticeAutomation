
using NUnit.Framework;
using OpenQA.Selenium;
using ThisIsMyWebSite.Pages;

namespace ThisIsMyWebSite.Scenarios
{
    [Parallelizable]
    public class LoginInvalidPassword
    {
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void InitializeDriver()
        {
            Driver = Actionss.InitializeDriver();
        }

        [Test]
        public void PassRandomPassword()
        {
            UtilityNavigation utNav = new UtilityNavigation(Driver);
            AuthenticationPage atPage = new AuthenticationPage(Driver);

            utNav.ClickSignIn();
            atPage.Login(Config.Credidentials.Valid.userName,Config.Credidentials.Invalid.invalidPassword);

        }

        [TearDown]
        public void ClearAll()
        {
            Driver.Quit();
        }

    }
}
