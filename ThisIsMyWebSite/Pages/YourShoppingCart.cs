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
    public class YourShoppingCart
    {
        public YourShoppingCart(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "cart_quantity_up_2_7_0_448569")]
        IWebElement IncrementQ { get; set; }

        [FindsBy(How = How.Id, Using = "cart_quantity_down_2_7_0_448569")]
        IWebElement DecrementQ { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='button btn btn-default standard-checkout button-medium']")]
        IWebElement Proceed { get; set; }

        public void QuantityFunc()
        {
            IncrementQ.Click();
            IncrementQ.Click();
            Thread.Sleep(1000);
            DecrementQ.Click();
        }

        public void ProceedToCart()
        {
            Proceed.Click();
        }

    }

}

