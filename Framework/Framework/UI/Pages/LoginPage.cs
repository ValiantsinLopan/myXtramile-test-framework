using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Framework.WebDriver;

namespace Framework.UI.Pages
{
    public class LoginPage
    {
        private const string Url = "http://app.xtramile.tech/";
        private const string UrlForRegistration = "http://app.xtramile.tech/?userId=157";

        private IWebElement LoginInput => DriverFactory.Driver.FindElement(By.XPath("//*[@id='email']"));
        private IWebElement PasswordInput => DriverFactory.Driver.FindElement(By.XPath("//*[@id='password']"));
        private IWebElement LoginButton => DriverFactory.Driver.FindElement(By.XPath("//*[@id='basic-tab1']//button"));
        private IWebElement LoginFailedMessage => DriverFactory.Driver.FindElement(By.XPath("//div[@class='brighttheme ui-pnotify-container brighttheme-error ui-pnotify-shadow']"));
        private IWebElement SwitchToRegister => DriverFactory.Driver.FindElement(By.XPath("//a[@href='#basic-tab2']"));
        private IWebElement FullNameInput => DriverFactory.Driver.FindElement(By.XPath("//input[@placeholder='Full name']"));
        private IWebElement EmailInput => DriverFactory.Driver.FindElement(By.XPath("//input[@id='ember524']"));
        private IWebElement NewUserPasswordInput => DriverFactory.Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        private IWebElement CompanyNameInput => DriverFactory.Driver.FindElement(By.XPath("//input[@placeholder='Company name']"));
        private IWebElement RegisterButton => DriverFactory.Driver.FindElement(By.XPath("//button[@id='signup-button']"));
        public void NavigateHere()
        {
            DriverFactory.Driver.Navigate().GoToUrl(Url);
        }
        public void NavigateForRegistration()
        {
            DriverFactory.Driver.Navigate().GoToUrl(UrlForRegistration);
            SwitchToRegister.Click();
        }
        public void LoginMyXtramile(string login, string password)
        {
            LoginInput.SendKeys(login);
            PasswordInput.SendKeys(password);
            LoginButton.Click();
        }

        public void RegisterUser(string name, string email, string password, string company)
        {
            FullNameInput.SendKeys(name);
            EmailInput.SendKeys(email);
            NewUserPasswordInput.SendKeys(password);
            CompanyNameInput.SendKeys(company);
            RegisterButton.Click();
        }

         public bool IsLoginFailedMessageDisplayed()
        {
            return LoginFailedMessage.Displayed;
        }

    }
}
