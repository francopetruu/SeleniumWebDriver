using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class IFrameHelper
    {
        public static void SwitchToFrame(By locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(locator));
        }
        public static void SwitchToParentFrame()
        {
            ObjectRepository.Driver.SwitchTo().DefaultContent();
        }
    }
}
