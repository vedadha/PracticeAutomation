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
    public class ShippingPage
    {
        public ShippingPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "cgv")]
        IWebElement IAgreeCheck { get; set; }

        [FindsBy(How = How.Name, Using = "processCarrier")]
        IWebElement ProceedToCheckOut { get; set; }

        public void IAgreeCheckBox()
        {
            IAgreeCheck.Click();
            Thread.Sleep(1000);
        }

        public void ProceedCheckOut()
        {
            ProceedToCheckOut.Click();
        }

    }
}
