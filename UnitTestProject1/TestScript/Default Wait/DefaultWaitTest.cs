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

namespace UnitTestProject1.TestScript.Default_Wait
{
    [TestClass]
    public class DefaultWaitTest
    {
        [TestMethod]
        public void TestDefaultWait()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'uid']"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'password']"), ObjectRepository.Config.GetPassword());
            Console.WriteLine(ButtonHelper.GetButtonText(By.XPath("//input[@name= 'btnLogin']")));
            Console.WriteLine(ButtonHelper.IsButtonEnabled(By.XPath("//input[@name= 'btnLogin']")));
            ButtonHelper.ClickButton(By.XPath("//input[@name= 'btnLogin']"));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(ObjectRepository.Driver.FindElement(By.XPath("//a[text()= 'Manager']")));
            wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            wait.Timeout = TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            Console.WriteLine(wait.Until(elementIsVisible()));
        }
        private Func<IWebElement, string> elementIsVisible()
        {
            return (x =>
            {
                Console.WriteLine("Waiting for element visible");
                if(x.Displayed == true)
                {
                    return x.Text;
                }
                else
                {
                    return null;
                }
            });
        } 
    }
}
