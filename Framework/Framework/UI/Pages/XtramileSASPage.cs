using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Pages
{
    public class XtramileSASPage
    {
        private IWebElement PasswordInput => DriverFactory.Driver.FindElement(By.XPath("//input[@id='CustomerPassword']"));
        private IWebElement ConfirmPasswordInput => DriverFactory.Driver.FindElement(By.XPath("//input[@id='CustomerPasswordConfirmation']"));
        private IWebElement ActivateButton => DriverFactory.Driver.FindElement(By.XPath("//input[@value='Activer le compte']"));

        public void ConfirmDeposit(string password)
        {
            PasswordInput.SendKeys(password);
            ConfirmPasswordInput.SendKeys(password);
            ActivateButton.Click();
        }
    }
}
