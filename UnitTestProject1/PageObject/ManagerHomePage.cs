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
    public class ManagerHomePage : BasePage
    {
        private IWebDriver driver;
        public ManagerHomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElements
        private By managerIdBanner = By.XPath("//td[contains(text(), 'Manger Id')]");
        private By welcomeBanner = By.XPath("//marquee[contains(text(), 'Welcome')]");
        #endregion

        #region Actions
        public string GetBannerWelcomeMessage()
        {
            return driver.FindElement(welcomeBanner).Text;
        }
        public string GetManagerId()
        {
            return driver.FindElement(managerIdBanner).Text;
        }
        #endregion

        #region Navigation
        #endregion
    }
}
