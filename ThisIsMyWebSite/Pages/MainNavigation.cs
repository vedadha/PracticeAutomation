using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThisIsMyWebSite.Pages
{
    class MainNavigation
    {

        public MainNavigation(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(1) > a")]
        IWebElement Woman { get; set; }

        [FindsBy(How = How.LinkText, Using = "Dresses")]
        IWebElement Dresses { get; set; }

        [FindsBy(How = How.LinkText, Using = "T-shirts")]
        IWebElement Tshirts { get; set; }

        [FindsBy(How = How.LinkText, Using = "Blouses")]
        IWebElement Blouses { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li:nth-child(1) > ul > li:nth-child(1) > a")]
        IWebElement Tops { get; set; }

        public void HoverWoman(IWebDriver driver)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(Woman).Perform();
            Thread.Sleep(2000);
        }

        public void ClickBlouses(IWebDriver driver)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(Blouses).Click().Perform();
            Thread.Sleep(1000);
        }

    }
}
