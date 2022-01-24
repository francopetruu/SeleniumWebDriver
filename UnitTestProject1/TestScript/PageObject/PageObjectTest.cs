using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class PageObjectTest
    {
        [TestMethod]
        public void TestPageObjectModel()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LoginPage login = new LoginPage(ObjectRepository.Driver);
            login.SetUserName(ObjectRepository.Config.GetUserName());
            login.SetPassword(ObjectRepository.Config.GetPassword());
        }
    }
}
