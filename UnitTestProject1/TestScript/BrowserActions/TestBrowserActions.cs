using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.BrowserActions
{
    [TestClass]
    public class TestBrowserActions
    {
        [TestMethod]
        public void BrowserActionsTest()
        {
            NavigationHelper.NavigateToUrl("https://www.google.com/");
            ButtonHelper.ClickButton(By.XPath("//div[@class= 'FPdoLc lJ9FBc']//input[@name= 'btnI']"));
            BrowserHelper.BrowserBack();
            BrowserHelper.BrowserForward();
            BrowserHelper.BrowserRefresh();
        }
    }
}
