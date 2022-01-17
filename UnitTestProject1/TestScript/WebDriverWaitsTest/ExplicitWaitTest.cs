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
            dynamicWait.PollingInterval = TimeSpan.FromSeconds(250);
            dynamicWait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            dynamicWait.Until(waitForSearchBox());
        }
        private Func<IWebDriver, bool> waitForSearchBox()
        {
            return ((x) =>
            {
                Console.WriteLine("Waiting for searchbox");
                return x.FindElements(By.XPath("//input[@name= 'uid']")).Count == 1;
            });
        }
    }
}
