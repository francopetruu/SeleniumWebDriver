using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.PageObject;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.PageObject
{
    [TestClass]
    public class NewCustomerPageTest
    {
        private IWebDriver driver = ObjectRepository.Driver;

        [TestMethod]
        public void TestNewCustomerPage()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LoginPage login = new LoginPage(driver);
            SidebarPage sidebar = new SidebarPage(driver);
            NewCustomerPage newCustomer = new NewCustomerPage(driver);
            login.SetUserName(ObjectRepository.Config.GetUserName(), "UserID");
            login.SetPassword(ObjectRepository.Config.GetPassword(), "Password");
            login.ClickOnLoginButton("LOGIN");
            sidebar.ClickSideBarLinkByText("New Customer");
            newCustomer.SetCustomerName("Franco", "Customer Name");
            newCustomer.SetGender("m");
            newCustomer.SetDateOfBirth("24021993", "Date of Birth");
        }
    }
}
