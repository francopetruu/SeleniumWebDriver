using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.PageObject
{
    public class ManagerHomePage : BasePage
    {
        #region WebElements
        private By managerIdBanner = By.XPath("//td[contains(text(), 'Manger Id')]");
        private By welcomeBanner = By.XPath("//marquee[contains(text(), 'Welcome')]");
        
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
