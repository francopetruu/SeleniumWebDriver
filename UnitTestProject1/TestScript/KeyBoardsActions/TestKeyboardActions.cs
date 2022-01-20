using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.KeyBoardsActions
{
    [TestClass]
    public class TestKeyboardActions
    {
        [TestMethod]
        public void KeyboardActionsTest()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            KeyboardActionsHelper.PressThreeKeys(Keys.LeftAlt, "f", "x");
        }
    }
}
