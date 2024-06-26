﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.PageObject
{
    public class BasePage
    {
        private IWebDriver driver;
        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        #region WebElements
        private By linkElementByText = By.XPath("//a[contains(text(), 'REPLACE')]");
        private By inputElementByLabel = By.XPath("//td[text()= 'REPLACE']/following-sibling::td/input");
        private By textAreaElementByLabel = By.XPath("//td[text()= 'REPLACE']/following-sibling::td/textarea");
        private By buttonElementByLabel = By.XPath("//input[@value= 'REPLACE']");
        #endregion

        #region Actions
        protected IWebElement GetLinkElementByText(string text)
        {
            var locator = linkElementByText.ToString().Substring(10).Replace("REPLACE", text);
            return driver.FindElement(By.XPath(locator));
        }
        protected IWebElement GetInputElementByLabel(string label)
        {
            var locator = inputElementByLabel.ToString().Substring(10).Replace("REPLACE", label);
            return driver.FindElement(By.XPath(locator));
        }
        protected IWebElement GetTextAreaElementByLabel(string label)
        {
            var locator = textAreaElementByLabel.ToString().Substring(10).Replace("REPLACE", label);
            return driver.FindElement(By.XPath(locator));
        }
        protected IWebElement GetButtonElementBylabel(string label)
        {
            var locator = buttonElementByLabel.ToString().Substring(10).Replace("REPLACE", label);
            return driver.FindElement(By.XPath(locator));
        }
        public void ClickOnButtonByLabel(string label)
        {
            GetButtonElementBylabel(label).Click();
        }
        public void ClickOnLinkByText(string text)
        {
            GetLinkElementByText(text).Click();
        }
        #endregion
    }
}
