using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.Screenshot
{
    [TestClass]
    public class TakeScreenShot
    {
        [TestMethod]
        public void TakeScreenShotTest()
        {

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'uid']"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'password']"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.XPath("//input[@name= 'btnLogin']"));
            GenericHelper.TakeScreenshot();
            GenericHelper.TakeScreenshot("newScreenshot");
        }
    }
}
