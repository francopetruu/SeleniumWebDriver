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

namespace UnitTestProject1.TestScript.MultipleBrowser
{
    [TestClass]
    public class TestMultipleBrowserWindows
    {
        [TestMethod]
        public void MultipleBrowserWindowsTest()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ClickButton(By.XPath("(//a[text()= 'Try it Yourself »'])[1]"));
            BrowserHelper.SwitchToWindow(1);
            ButtonHelper.ClickButton(By.XPath("//button[@id= 'runbtn']"));
        }
    }
}
