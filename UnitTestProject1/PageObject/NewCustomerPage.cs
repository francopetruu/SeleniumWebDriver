using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;

namespace UnitTestProject1.PageObject
{
    public class NewCustomerPage : BasePage
    {
        private IWebDriver driver;
        private Regex regex = new Regex("^[0-9]+$");
        public NewCustomerPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElements
        private By FemaleRadioButton = By.XPath("//input[@value = 'f']");
        private By MaleRadioButton = By.XPath("//input[@value = 'm']");
        private By DateOfBirthInput = By.XPath("//input[@type= 'date']");
        #endregion

        #region Actions
        public void SetCustomerName(string name, string label)
        {
            GetInputElementByLabel(label).SendKeys(name);
        }
        public void SetGender(string gender)
        {
            if (gender.ToLower().Equals("m"))
            {
                RadioButtonHelper.ClickRadioButton(MaleRadioButton);
            }
            else if (gender.ToLower().Equals("f"))
            {
                RadioButtonHelper.ClickRadioButton(FemaleRadioButton);
            }
            else
            {
                Console.WriteLine("Invalid gender: please write m or f");
                throw new NoSuchElementException();
            }
        }
        public void SetDateOfBirth(string ddMMyyyy, string label)
        {
            GetInputElementByLabel(label).SendKeys(ddMMyyyy);
        }
        public void SetAddress(string address, string label)
        {
            GetTextAreaElementByLabel(label).SendKeys(address);
        }
        public void SetCity(string city, string label)
        {
            GetInputElementByLabel(label).SendKeys(city);
        }
        public void SetState(string state, string label)
        {
            GetInputElementByLabel(label).SendKeys(state);
        }
        public void SetPin(string pinNumber, string label)
        {
            try
            {
                if (pinNumber.Length.Equals(6) && regex.IsMatch(pinNumber))
                {
                    GetInputElementByLabel(label).SendKeys(pinNumber);
                }
                else
                {
                    Console.WriteLine("PIN Code must have 6 digits, only numbers allowed");
                    throw new FormatException();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
        public void SetMobileNumber(string number, string label)
        {
            try
            {
                if (regex.IsMatch(number))
                {
                    GetInputElementByLabel(label).SendKeys(number);
                }
                else
                {
                    Console.WriteLine("Only numbers allowed");
                    throw new FormatException();
                }
            }
            catch (FormatException ex)
            {
                Console.Write(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }   
        }
        public void SetMailAddress(string mail, string label)
        {
            try
            {
                MailAddress email = new MailAddress(mail);
                GetInputElementByLabel(label).SendKeys(mail);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            } 
        }
        public void SetNewPassword(string newPass, string label)
        {
            GetInputElementByLabel(label).SendKeys(newPass);
        }
        #endregion

        #region Navigation
        #endregion
    }
}
