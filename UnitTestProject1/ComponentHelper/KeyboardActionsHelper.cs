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
    public class KeyboardActionsHelper
    {
        private static Actions actions;
        public static void PressTwoKeys(string key, string letter)
        {
            actions = new Actions(ObjectRepository.Driver);
            actions.KeyDown(key)
                .SendKeys(letter)
                .KeyUp(key)
                .Build()
                .Perform();
        }
        public static void PressThreeKeys(string firstkey, string secondKey, string letter)
        {
            actions = new Actions(ObjectRepository.Driver);
            actions.KeyDown(firstkey)
                .KeyDown(secondKey)
                .SendKeys(letter)
                .KeyUp(secondKey)
                .KeyUp(firstkey)
                .Build()
                .Perform();
        }
    }
}
