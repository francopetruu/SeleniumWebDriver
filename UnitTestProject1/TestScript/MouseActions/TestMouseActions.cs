using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.MouseActions
{
    [TestClass]
    public class TestMouseActions
    {
        [TestMethod]
        public void TestContextClick()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            MouseActionsHelper.ContextClickOnElement(By.Id("draggable"));
            Thread.Sleep(5000);
        }
        [TestMethod]
        public void TestDragAndDrop()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            MouseActionsHelper.DragAndDropElement(By.Id("draggable"), By.Id("droptarget"));
            Thread.Sleep(10000);
        }
        [TestMethod]
        public void TestClickAndHold()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/sortable/index");
            MouseActionsHelper.ClickAndHoldElement(By.XPath("//li[text()= 'Pushing Me Away ']"), By.XPath("//li[text()= 'One Step Closer ']"), 0, 30);
            Thread.Sleep(10000);
        }
    }
}
