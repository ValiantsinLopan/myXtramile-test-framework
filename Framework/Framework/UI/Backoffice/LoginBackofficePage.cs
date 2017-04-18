using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Backoffice
{
    public class LoginBackofficePage
    {

        private const string Url = "http://backoffice.xtramile.tech/";
        private IWebElement LoginInput => DriverFactory.Driver.FindElement(By.XPath("//input[@id='email']"));
        private IWebElement PasswordInput => DriverFactory.Driver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement SignInButton => DriverFactory.Driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-block']"));

        public void NavigateHere()
        {
            DriverFactory.Driver.Navigate().GoToUrl(Url);
        }
        public void LoginBackoffice(string login, string password)
        {
            LoginInput.SendKeys(login);
            PasswordInput.SendKeys(password);
            SignInButton.Click();
        }

    }
}
