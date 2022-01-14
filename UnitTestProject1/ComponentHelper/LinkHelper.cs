using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ComponentHelper
{
    public class LinkHelper
    {
        private static IWebElement element;
        public static void ClickLink(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Click();
        }
        public static void ClickLinkByText(string text)
        {
            element = GenericHelper.GetElementByText(text);
            element.Click();
        }
    }
}
