using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Pages
{
    public class LoginPage
    {
        private const string Url = "http://app.xtramile.tech/";

        private IWebElement LoginInput => DriverFactory.Driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement PasswordInput => DriverFactory.Driver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement LoginButton => DriverFactory.Driver.FindElement(By.XPath("//*[@id='basic-tab1']//button"));
        private IWebElement LoginFailedMessage => DriverFactory.Driver.FindElement(By.XPath("//div[@class='brighttheme ui-pnotify-container brighttheme-error ui-pnotify-shadow']"));

        public void NavigateHere()
        {
            DriverFactory.Driver.Navigate().GoToUrl(Url);
        }
        public void LoginMyXtramile(string login, string password)
        {
            LoginInput.SendKeys(login);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }
         public bool IsLoginFailedMessageDisplayed()
        {
            return LoginFailedMessage.Displayed;
        }

    }
}
