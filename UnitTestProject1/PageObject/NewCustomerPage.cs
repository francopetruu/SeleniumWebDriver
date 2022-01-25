using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.ComponentHelper;

namespace UnitTestProject1.PageObject
{
    public class NewCustomerPage : BasePage
    {
        private IWebDriver driver;
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
                Console.WriteLine("Invalid gender: please write male or female");
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

        #endregion

        #region Navigation
        #endregion
    }
}
