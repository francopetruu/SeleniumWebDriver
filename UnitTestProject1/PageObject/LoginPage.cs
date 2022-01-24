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
        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElements
        private By userIdTextBox = By.Name("uid");
        private By passwordTextBox = By.Name("password");
        private By loginButton = By.Name("btnLogin");
        private By resetButton = By.Name("btnReset");
        private By hereLink = By.XPath("//a[text()= 'here']");
        #endregion

        #region Actions
        public void SetUserName(string user, string label)
        {
            GetInputElementByLabel(label).SendKeys(user);
        }
        public void SetPassword(string pass, string label)
        {
            GetInputElementByLabel(label).SendKeys(pass);
        }
        public void ClickOnLoginButton(string buttonLabel)
        {
            GetButtonElementBylabel(buttonLabel).Click();
        }
        public void ClickOnResetButton(string buttonLabel)
        {
            GetButtonElementBylabel(buttonLabel).Click();
        }
        #endregion

        #region Navigation
        public void NavigateToGenerateAccessPage()
        {
            driver.FindElement(hereLink).Click();
        } 
        #endregion
    }
}
