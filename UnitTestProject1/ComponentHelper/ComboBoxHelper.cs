using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;
        public static void SelectElementByIndex(By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);
        }
        public static void SelectElementByText(By locator, string text)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByText(text);
        }
        public static void SelectElementByValue(By locator, string value)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(value);
        }
        public static IList<string> GetAllItems(By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
    }
}
