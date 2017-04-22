using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Pages
{
    public class MainPage
    {
        private IWebElement UserDropdown => DriverFactory.Driver.FindElement(By.XPath("//li[@class='dropdown dropdown-user']/a"));
        private IWebElement AccountSettings => DriverFactory.Driver.FindElement(By.XPath("//ul[@class='dropdown-menu dropdown-menu-right']//a[@href='/myaccount/company']"));
    }
}
