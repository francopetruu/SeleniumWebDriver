using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class MouseActionsHelper
    {
        private static IWebElement element;
        private static IWebElement target;
        private static Actions actions;
        public static void ContextClickOnElement(By locator)
        {
            element = GenericHelper.GetElement(locator);
            actions = new Actions(ObjectRepository.Driver);
            actions.ContextClick(element)
                .Build()
                .Perform();
        }
        public static void DragAndDropElement(By firstLocator, By secondLocator)
        {
            element = GenericHelper.GetElement(firstLocator);
            target = GenericHelper.GetElement(secondLocator);
            actions = new Actions(ObjectRepository.Driver);
            actions.DragAndDrop(element, target)
                .Build()
                .Perform();
        }
        public static void ClickAndHoldElement(By firstLocator, By secondLocator, int offsetX, int offsetY)
        {
            element = GenericHelper.GetElement(firstLocator);
            target = GenericHelper.GetElement(secondLocator);
            actions = new Actions(ObjectRepository.Driver);
            actions.ClickAndHold(element)
                .MoveToElement(target, offsetX, offsetY)
                .Release()
                .Build()
                .Perform();
        }
    }
}
