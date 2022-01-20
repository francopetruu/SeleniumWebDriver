using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Settings;

namespace UnitTestProject1.ComponentHelper
{
    public class JavaScriptExecutorHelper
    {
        private static IJavaScriptExecutor executor;
        public static void ClickByJavaScriptExecutor(string elementId)
        {
            executor = ((IJavaScriptExecutor)ObjectRepository.Driver);
            executor.ExecuteScript("document.getElementById('" + elementId + "').click()");
        }
        public static void SendKeysByJavaScriptExecutor(string elementId, string text)
        {
            executor = ((IJavaScriptExecutor)ObjectRepository.Driver);
            executor.ExecuteScript("document.getElementById('" + elementId + "').value='" + text + "'");
        }
    }
}
