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
    public class SidebarPage
    {
        public SidebarPage()
        {
            PageFactory.InitElements(ObjectRepository.Driver, this);
        }

        #region WebElements
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Manager')]")]
        private IWebElement managerLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'New Customer')]")]
        private IWebElement newCustomerLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Edit Customer')]")]
        private IWebElement editCustomerLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Delete Customer')]")]
        private IWebElement deleteCustomerLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'New Account')]")]
        private IWebElement newAccountLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Edit Account')]")]
        private IWebElement editAccountLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Delete Account')]")]
        private IWebElement deleteAccountLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Deposit')]")]
        private IWebElement depositLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Withdrawal')]")]
        private IWebElement withdrawalLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Fund Transfer')]")]
        private IWebElement fundTransferLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Change Password')]")]
        private IWebElement changePasswordLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Balance Enquiry')]")]
        private IWebElement balanceEnquiryLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Mini Statement')]")]
        private IWebElement miniStatementLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Customised Statement')]")]
        private IWebElement customisedStatementLink;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Log out')]")]
        private IWebElement logoutLink;
        #endregion

        #region Actions
        public void ClickOnManagerLink()
        {
            managerLink.Click();
        }
        public void ClickOnNewCustomerLink()
        {
            newCustomerLink.Click();
        }
        #endregion
    }
}
