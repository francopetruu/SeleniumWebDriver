using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.PageObject
{
    public class LoginPage
    {
        #region WebElements
        private By userIdTextBox = By.Name("uid");
        private By passwordTextBox = By.Name("password");
        private By loginButton = By.Name("btnLogin");
        private By resetButton = By.Name("btnReset");
        private By hereLink = By.XPath("//a[text()= 'here']");
        #endregion

        #region Actions
        public void SetUserName(string user)
        {
            ObjectRepository.Driver.FindElement(userIdTextBox).SendKeys(user);
        }
        public void SetPassword(string pass)
        {
            ObjectRepository.Driver.FindElement(passwordTextBox).SendKeys(pass);
        }
        public void ClickOnLoginButton()
        {
            ObjectRepository.Driver.FindElement(loginButton).Click();
        }
        public void ClickOnResetButton()
        {
            ObjectRepository.Driver.FindElement(resetButton).Click();
        }
        #endregion

        #region Navigation
        public void NavigateToGenerateAccessPage()
        {
            ObjectRepository.Driver.FindElement(hereLink).Click();
        } 
        #endregion
    }
}
