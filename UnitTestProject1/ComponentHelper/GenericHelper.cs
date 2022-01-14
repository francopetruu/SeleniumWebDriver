using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element not found: " + locator.ToString());
            }
        }
        public static IWebElement GetElementByText(string text)
        {
            if (IsElementPresent(By.XPath("//*[text()= '" + text + "']")))
            {
                return ObjectRepository.Driver.FindElement(By.XPath("//*[text()= '" + text + "']"));
            }
            else
            {
                throw new NoSuchElementException("Element not found: " + (By.XPath("//*[text()= '" + text + "']")).ToString());
            }
        }
        public static void TakeScreenshot(string filename = "Screenshot")
        {
            ITakesScreenshot screenshot = ((ITakesScreenshot)ObjectRepository.Driver);
            if (filename.Equals("Screenshot"))
            {
                string name = filename + DateTime.Now.ToString("dd-MM-yyyy-hh-mm") + ".jpeg";
                screenshot.GetScreenshot().SaveAsFile(name, ScreenshotImageFormat.Jpeg);
                return;
            }
            screenshot.GetScreenshot().SaveAsFile(filename + ".jpeg", ScreenshotImageFormat.Jpeg);
        }
    }
}
