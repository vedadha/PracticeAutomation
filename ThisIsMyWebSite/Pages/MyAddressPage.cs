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
    public class MyAddressPage
    {
        public MyAddressPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='address_delivery']/li[7]/a")]
        IWebElement UpdateDeliveryAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='button btn btn-default button-medium']")]
        IWebElement ProceedToCheckout { get; set; }


        public void ProceedToCheckOut()
        {
            ProceedToCheckout.Click();
        }

    }
}
