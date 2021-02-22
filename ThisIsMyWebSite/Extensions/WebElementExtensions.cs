using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EAAutoFramework.Extensions
{
    public static class WebElementExtensions
    {

        //This method slect item from drop down list
        public static void SelectDropDownList(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

        //This method Assert elements existance, and throw Exception if there is no element
        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
                throw new Exception(string.Format("Element not Present exception"));
        }

        //This method checking is element present on site
        private static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static void GetSelectedDropDown(this IWebElement element)
        {
            //Prvo pravimo objekat za selektovanje
            SelectElement ddl = new SelectElement(element);
            ddl.AllSelectedOptions.First();
        }

        public static IList<IWebElement> GetSelectedListOptions(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions;
        }

        //This method Move element from one location to another
        public static void MoveElements(Actions action, IWebElement from, IWebElement to, int x = 0, int y = 0)
        {
            action.ClickAndHold(from)
                  .MoveToElement(to)
                  .MoveByOffset(x, y)
                  .Build()
                  .Perform();
        }

        
    }
}
