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
    public class YourPaymentPage
    {
        public YourPaymentPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='bankwire']")]
        IWebElement PayByBankWire { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='cheque']")]
        IWebElement PayByCheck { get; set; }

        public void BankWire()
        {
            PayByBankWire.Click();
            Thread.Sleep(3000);
        }

        public void PayCheck()
        {
            PayByCheck.Click();
            Thread.Sleep(3000);
        }
    }
}
