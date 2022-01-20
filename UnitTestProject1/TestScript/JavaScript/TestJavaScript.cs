using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.JavaScript
{
    [TestClass]
    public class TestJavaScript
    {
        [TestMethod]
        public void JavaScriptTest()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)ObjectRepository.Driver);
        }
    }
}
