using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'uid']"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'password']"), ObjectRepository.Config.GetPassword());
        }
    }
}
