using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.PopUps
{
    [TestClass]
    public class TestPopups
    {
        [TestMethod]
        public void PopupsTest()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ClickButton(By.XPath("(//a[text()= 'Try it Yourself »'])[1]"));
            BrowserHelper.SwitchToWindow(1);
            IFrameHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text()= 'Try it']"));
            var alertText = JavaScriptPopupHelper.GetPopupText();
            JavaScriptPopupHelper.AcceptAlert();
            IFrameHelper.SwitchToParentFrame();
        }
        [TestMethod]
        public void ConfirmPopupTest()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_confirm");
            IFrameHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text()= 'Try it']"));
            JavaScriptPopupHelper.CancelAlert();
        }
        [TestMethod]
        public void PromptPopupTest()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/tryit.asp?filename=tryjs_prompt");
            IFrameHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[text()= 'Try it']"));
            JavaScriptPopupHelper.SendKeysToAlert("This is my name");
            JavaScriptPopupHelper.AcceptAlert();
        }
    }
}
