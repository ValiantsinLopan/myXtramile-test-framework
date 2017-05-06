using Framework.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.UI.Mailinator
{
    public class LetterPage
    {
        private IWebElement ContentTypeDropDown => DriverFactory.Driver.FindElement(By.XPath("//*[@id='publiccontenttypeselect']"));
        private IWebElement ActivationLink => DriverFactory.Driver.FindElement(By.XPath("html/body/a"));

        private string MailFrameId = "publicshowmaildivcontent";

        public void ChangeContentType()
        {
            var select = new SelectElement(ContentTypeDropDown);
            select.SelectByValue("text/plain");
        }

        public void FollowActivationLink()
        {
            DriverFactory.Driver.SwitchTo().Frame(MailFrameId);
            ActivationLink.Click();

        }
    }
}
