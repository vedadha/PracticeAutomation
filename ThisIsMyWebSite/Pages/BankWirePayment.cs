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
    public class BankWirePayment
    {
        public BankWirePayment(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@class='button btn btn-default button-medium']")]
        IWebElement ConfirmOrder { get; set; }

        public void ClickIConfirmOrder()
        {
            ConfirmOrder.Click();
            Thread.Sleep(3000);
        }
    }
}
