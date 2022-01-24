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
    public class LoginPage : BasePage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region WebElements
        [FindsBy(How = How.Name, Using = "uid")]
        private IWebElement userIdTextBox;
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordTextBox;
        [FindsBy(How = How.Name, Using = "btnLogin")]
        private IWebElement loginButton;
        [FindsBy(How = How.Name, Using = "btnReset")]
        private IWebElement resetButton;
        [FindsBy(How = How.XPath, Using = "//a[text()= 'here']")]
        private IWebElement hereLink;
        #endregion

        #region Actions
        public void SetUserName(string user)
        {
            userIdTextBox.SendKeys(user);
        }
        public void SetPassword(string pass)
        {
            passwordTextBox.SendKeys(pass);
        }
        public void ClickOnLoginButton()
        {
            loginButton.Click();
        }
        public void ClickOnResetButton()
        {
            resetButton.Click();
        }
        #endregion

        #region Navigation
        public void NavigateToGenerateAccessPage()
        {
            hereLink.Click();
        } 
        #endregion
    }
}
