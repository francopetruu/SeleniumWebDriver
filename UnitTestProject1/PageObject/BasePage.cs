using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.PageObject
{
    public abstract class BasePage
    {
        #region WebElements
        private By linkElementByText = By.XPath("//a[contains(text(), 'REPLACE')]");
        private By inputElementByLabel = By.XPath("//td[text()= 'REPLACE']/following-sibling::td/input");
        private By textAreaElementByLabel = By.XPath("//td[text()= 'REPLACE']/following-sibling::td/textarea");
        private By buttonElementByLabel = By.XPath("//input[@value= 'REPLACE']");
        #endregion

        #region Actions
        public IWebElement GetLinkElementByText(string text)
        {
            var locator = linkElementByText.ToString().Replace("REPLACE", text);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        public IWebElement GetInputElementByLabel(string label)
        {
            var locator = inputElementByLabel.ToString().Replace("REPLACE", label);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        public IWebElement GetTextAreaElementByLabel(string label)
        {
            var locator = textAreaElementByLabel.ToString().Replace("REPLACE", label);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        public IWebElement GetButtonElementBylabel(string label)
        {
            var locator = buttonElementByLabel.ToString().Replace("REPLACE", label);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        #endregion
    }
}
