using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Pages
{
    public class CreateJobPage
    {
        private IWebElement JobTitle => DriverFactory.Driver.FindElement(By.XPath(""));
        private IWebElement JobTtype => DriverFactory.Driver.FindElement(By.XPath(""));
    }
}
