﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.Button
{
    [TestClass]
    public class TestButton
    {
        [TestMethod]
        public void ButtonTest()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'uid']"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'password']"), ObjectRepository.Config.GetPassword());
            Console.WriteLine(ButtonHelper.GetButtonText(By.XPath("//input[@name= 'btnLogin']")));
            Console.WriteLine(ButtonHelper.IsButtonEnabled(By.XPath("//input[@name= 'btnLogin']")));
            ButtonHelper.ClickButton(By.XPath("//input[@name= 'btnLogin']"));
        }
    }
}
