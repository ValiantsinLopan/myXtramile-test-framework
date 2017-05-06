using System;
using Framework.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace Framework.UI.Mailinator
{
    public class MainPage
    {
        private const string Url = "https://www.mailinator.com/";

        private IWebElement EmailInput => DriverFactory.Driver.FindElement(By.XPath("//*[@id='inboxfield']"));
        private IWebElement GoButton => DriverFactory.Driver.FindElement(By.XPath("//span[@class='input-group-btn']/button"));

        public void NavigateHere()
        {
            DriverFactory.Driver.Navigate().GoToUrl(Url);
        }

        public void GoToEmail(string email)
        {
            EmailInput.SendKeys(email);
            GoButton.Click();
        }
    }
}