using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public static void SwitchToWindow(int index)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            if(windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window index: " + index);
            }
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            BrowserMaximize();
        }
        public static void SwitchToParent()
        {
            var windowsIds = ObjectRepository.Driver.WindowHandles;
            for(int i= windowsIds.Count; i > 0; i--)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.SwitchTo().Window(windowsIds[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowsIds[0]);
        }
    }
}
