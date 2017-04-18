using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Backoffice
{
    public class MainPage
    {
        private IWebElement UsersItem => DriverFactory.Driver.FindElement(By.XPath("//a[@href='#/users/index']"));
        public void GoToUserList()
        {
            UsersItem.Click();
        }
    }
}
