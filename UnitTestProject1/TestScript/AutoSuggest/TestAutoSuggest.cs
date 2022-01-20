using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;
using UnitTestProject1.Settings;

namespace UnitTestProject1.TestScript.AutoSuggest
{
    [TestClass]
    public class TestAutoSuggest
    {
        [TestMethod]
        public void AutoSuggestTest()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/autocomplete/index");
            TextBoxHelper.TypeOnTextBox(By.Id("countries"), "a");
            AutoSuggestHelper.ClickOnAutoSuggestOption(By.XPath("//ul[@id= 'countries_listbox']//li"), "Austria");
            Thread.Sleep(10000);
        }
    }
}
