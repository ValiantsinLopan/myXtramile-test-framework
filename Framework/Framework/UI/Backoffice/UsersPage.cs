using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Backoffice
{
    public class UsersPage
    {
        private IWebElement FilterInput => DriverFactory.Driver.FindElement(By.XPath("//input[@aria-controls='DataTables_Table_0']"));

        public void SearchByEmail(string email)
        {
            FilterInput.SendKeys(email);
        }
        public bool IsUserFound(string email)
        {
            return DriverFactory.Driver.FindElement(By.XPath($"//div[@class='datatable-scroll']//td[text()='{email}']")).Displayed;
        }
    }
}
