using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.WebDriverWaitsTest
{
    [TestClass]
    public class ImplicitWaitTest
    {
        [TestMethod]
        public void TestImplicitWaits()
        {
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
    }
}
