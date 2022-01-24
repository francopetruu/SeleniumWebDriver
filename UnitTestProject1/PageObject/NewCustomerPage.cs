using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObject
{
    public class NewCustomerPage : BasePage
    {
        private IWebDriver driver;
        public NewCustomerPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElements
        #endregion

        #region Actions
        public void SetCustomerName(string name, string label)
        {
            GetInputElementByLabel(label).SendKeys(name);
        }
        #endregion

        #region Navigation
        #endregion
    }
}
