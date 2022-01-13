using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void CheckBoxTest()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            CheckBoxHelper.IsCheckBoxChecked(By.XPath(""));
        }
    }
}
