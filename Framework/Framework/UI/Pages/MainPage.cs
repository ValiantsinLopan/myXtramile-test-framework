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
        private IWebElement AddJobButton => DriverFactory.Driver.FindElement(By.XPath("//a[@class='fab-menu-btn btn bg-pink-300 btn-float btn-rounded btn-icon legitRipple']"));
        private IWebElement NewJobButton => DriverFactory.Driver.FindElement(By.XPath("//button[@class='btn btn-default btn-rounded btn-icon btn-float legitRipple']"));
        public void SwitchToAppMainPage()
        {
            List<string> tabs = new List<string>(DriverFactory.Driver.WindowHandles);
            DriverFactory.Driver.SwitchTo().Window(tabs[1]);
        }

        public void GoToAccountSettingsPage()
        {
            UserDropdown.Click();
            AccountSettings.Click();
        }
        
        public void AddNewJob()
        {
            AddJobButton.Click();
            NewJobButton.Click();
        }
    }
}
