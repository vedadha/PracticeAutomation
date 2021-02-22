using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsMyWebSite.Pages
{
    public class UtilityNavigation
    {

        public UtilityNavigation(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "login")]
        IWebElement SignIn { get; set; }

        [FindsBy(How = How.Id, Using = "contact-link")]
        IWebElement ContactUs { get; set; }

        [FindsBy(How = How.ClassName, Using = "logout")]
        IWebElement LogOut { get; set; }

        [FindsBy(How = How.ClassName, Using = "account")]
        IWebElement Account { get; set; }


        public void ClickSignIn()
        {
            SignIn.AssertElementPresent();
            SignIn.Click();
        }

        public void ClickContactUs()
        {
            ContactUs.AssertElementPresent();
            ContactUs.Click();
        }

        public void ClickSignOut()
        {
            LogOut.AssertElementPresent();
            LogOut.Click();
        }

        public void ClickAccount()
        {
            Account.AssertElementPresent();
            Account.Click();
        }
    }
}
