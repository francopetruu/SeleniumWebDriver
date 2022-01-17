using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.WebDriverWaitsTest
{
    [TestClass]
    public class ExplicitWaitTest
    {
        [TestMethod]
        public void TestExplicitWaits()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait dynamicWait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(50));
            dynamicWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            dynamicWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            //dynamicWait.Until(waitForSearchBox());
            //Console.Write(dynamicWait.Until(waitForTitle()));
            IWebElement element = dynamicWait.Until(waitForElement());
            element.SendKeys("Dynamic wait test");
        }
        private Func<IWebDriver, bool> waitForSearchBox()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for searchbox");
                return x.FindElements(By.XPath("//input[@name= 'uid']")).Count == 1;
            });
        }
        private Func<IWebDriver, string> waitForTitle()
        {
            return ((x) =>
            {
                if(x.Title.Contains("Guru99 Bank"))
                {
                    return x.Title;
                }
                else
                {
                    return null;
                }
            });
        }
        private Func<IWebDriver, IWebElement> waitForElement()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for element");
                if(x.FindElements(By.XPath("//input[@name= 'uid']")).Count == 1)
                {
                    return x.FindElement(By.XPath("//input[@name= 'uid']"));
                }
                else
                {
                    return null;
                }
            });
        }
    }
}
