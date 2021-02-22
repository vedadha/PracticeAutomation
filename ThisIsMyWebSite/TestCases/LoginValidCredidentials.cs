
using NUnit.Framework;
using OpenQA.Selenium;
using ThisIsMyWebSite.Pages;

namespace ThisIsMyWebSite.TestCases
{
    [Parallelizable]

    public class LoginValidCredidentials
    {
        public IWebDriver Driver { get; set; }

        IAlert alert;

        [SetUp]
        public void InitializeDriver()
        {
            Driver = Actionss.InitializeDriver();
        }

        [Test]
        public void ValidCredidentials()
        {
            UtilityNavigation utNav = new UtilityNavigation(Driver);
            AuthenticationPage atPage = new AuthenticationPage(Driver);

            utNav.ClickSignIn();
            atPage.Login(Config.Credidentials.Valid.userName, Config.Credidentials.Valid.password);
            
        }

        [TearDown]
        public void ClearAll()
        {
            Driver.Quit();
        }
    }

    
}
