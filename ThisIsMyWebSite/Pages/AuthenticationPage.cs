using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThisIsMyWebSite.Pages
{
    public class AuthenticationPage
    {
        public AuthenticationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "email_create")]
        IWebElement EmailCreate { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        IWebElement SubmitCreate { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement Username { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#login_form > div > p.lost_password.form-group > a")]
        IWebElement ForgottenPassword { get; set; }



        public void Login(string email, string password)
        {
            Username.AssertElementPresent();
            Username.SendKeys(email);
            Thread.Sleep(300);
            
            Password.AssertElementPresent();
            Password.SendKeys(password);
            Thread.Sleep(300);

            SubmitButton.AssertElementPresent();
            SubmitButton.Click();
            Thread.Sleep(300);
        }

        public void CreateAccount(string email)
        {
            EmailCreate.AssertElementPresent();
            EmailCreate.SendKeys(email);
            Thread.Sleep(500);

            SubmitCreate.AssertElementPresent();
            SubmitCreate.Click();
            Thread.Sleep(2000);
        }
    }
}
