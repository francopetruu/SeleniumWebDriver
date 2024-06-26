﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                ReadOnlyCollection<IWebElement> list = ObjectRepository.Driver.FindElements(By.XPath("//input"));
                Console.WriteLine("Size: " + list.Count);
                Console.WriteLine("Element zero: " + list.ElementAt(0));
            } 
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
