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
        [FindsBy(How = How.XPath, Using = "//td[contains(text(), 'Manger Id')]")]
        private IWebElement managerIdBanner;
        [FindsBy(How = How.XPath, Using = "//marquee[contains(text(), 'Welcome')]")]
        private IWebElement welcomeBanner;
        #endregion

        #region Actions
        public string GetBannerWelcomeMessage()
        {
            return welcomeBanner.Text;
        }
        public string GetManagerId()
        {
            return managerIdBanner.Text;
        }
        #endregion

        #region Navigation
        #endregion
    }
}
