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
    public class SidebarPage : BasePage
    {
        private IWebDriver driver;
        public SidebarPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElements
        #endregion

        #region Actions
        public void ClickSideBarLinkByText(string text)
        {
            ClickOnLinkByText(text);
        }
        #endregion
    }
}
