using OpenQA.Selenium;
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
        public BasePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
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
            var locator = linkElementByText.ToString().Replace("REPLACE", text);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        protected IWebElement GetInputElementByLabel(string label)
        {
            var locator = inputElementByLabel.ToString().Replace("REPLACE", label);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        protected IWebElement GetTextAreaElementByLabel(string label)
        {
            var locator = textAreaElementByLabel.ToString().Replace("REPLACE", label);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        protected IWebElement GetButtonElementBylabel(string label)
        {
            var locator = buttonElementByLabel.ToString().Replace("REPLACE", label);
            return ObjectRepository.Driver.FindElement(By.XPath(locator));
        }
        #endregion
    }
}
