using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.FindAllElements
{
    [TestClass]
    public class FindAllElementsTest
    {
        [TestMethod]
        public void GetAllElementsTest()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.XPath("//input"));
            ReadOnlyCollection<IWebElement> noElements = ObjectRepository.Driver.FindElements(By.Id("123"));
            Console.WriteLine("Elements: " + elements.Count);
            Console.WriteLine("No elements: " + noElements.Count);
            foreach (var element in elements)
            {
                if (element.GetAttribute("id").Equals(""))
                {
                    Console.WriteLine("No id attribute for element: " + element);
                }
                else
                {
                    Console.WriteLine("ID: " + element.GetAttribute("id"));
                }
                
            }
        }
    }
}
