using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1.ComponentHelper
{
    public class AutoSuggestHelper
    {
        private static IWebElement element;
        public static void ClickOnAutoSuggestOption(By locator, string option)
        {
            Thread.Sleep(1000);
            var wait = GenericHelper.GetWebDriverWait(TimeSpan.FromSeconds(40));
            IList<IWebElement> elements = wait.Until(GetAllElements(By.XPath("//ul[@id= 'countries_listbox']//li")));
            foreach (var ele in elements)
            {
                if (ele.Text.Equals(option))
                {
                    ele.Click();
                }
            }
        }
        private static Func<IWebDriver, IList<IWebElement>> GetAllElements(By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator);
            });
        }
    }
}
