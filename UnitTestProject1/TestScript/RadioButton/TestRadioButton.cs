﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.RadioButton
{
    [TestClass]
    public class TestRadioButton
    {
        [TestMethod]
        public void RadioButtonTest()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'uid']"), ObjectRepository.Config.GetUserName());
            TextBoxHelper.TypeOnTextBox(By.XPath("//input[@name= 'password']"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.XPath("//input[@name= 'btnLogin']"));
            LinkHelper.ClickLinkByText("New Customer");
            Console.WriteLine("Radio button selected: " + RadioButtonHelper.IsRadioButtonSelected(By.XPath("//*[@value= 'm']")));
            RadioButtonHelper.ClickRadioButton(By.XPath("//*[@value= 'f']"));
            Console.WriteLine("Radio button selected: " + RadioButtonHelper.IsRadioButtonSelected(By.XPath("//*[@value= 'f']")));
        }
    }
}
