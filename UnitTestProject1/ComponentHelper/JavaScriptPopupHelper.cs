using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class JavaScriptPopupHelper
    {
        public static bool IsAlertPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException e)
            {
                return false;
            }
        }
        public static string GetPopupText()
        {
            if (IsAlertPresent())
            {
                return ObjectRepository.Driver.SwitchTo().Alert().Text;
            }
            else
            {
                return "";
            }
        }
        public static void AcceptAlert()
        {
            if (IsAlertPresent())
            {
                ObjectRepository.Driver.SwitchTo().Alert().Accept();
            }
            else
            {
                return;
            }
        }
    }
}
