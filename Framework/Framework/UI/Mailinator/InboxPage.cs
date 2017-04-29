using Framework.WebDriver;
using OpenQA.Selenium;

namespace Framework.UI.Mailinator
{
    public class InboxPage
    {
        private const string ActivateAccountLetteXPath = "//div[contains(text(), 'Activate Your WhiteLabel Site06 Profile')]";
        private IWebElement ActivateAccountLetter => DriverFactory.Driver.FindElement(By.XPath(ActivateAccountLetteXPath));
        private IWebElement EmptyInboxMessage => DriverFactory.Driver.FindElement(By.XPath("//div[@id='publicm8rguy']"));
        private bool IsElementPresent(By by)
        {
            try
            {
                DriverFactory.Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void OpenActivationLetter()
        {
            while (!IsElementPresent(By.XPath(ActivateAccountLetteXPath)))
            {
                DriverFactory.Driver.Navigate().Refresh();
            };
            ActivateAccountLetter.Click();
        }
    }
}