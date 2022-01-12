using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            try
            {
                ObjectRepository.Driver.FindElement(By.XPath("//input[@name= 'uid']"));
                ObjectRepository.Driver.FindElement(By.XPath("//input[@name= 'uid1']"));
            } 
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
