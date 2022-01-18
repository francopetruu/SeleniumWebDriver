using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public static void BrowserBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }
        public static void BrowserForward()
        {
            ObjectRepository.Driver.Navigate ().Forward();
        }
        public static void BrowserRefresh()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }
    }
}
