using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Pages
{
    public class PaymentInformationForm
    {
        private const string PaymentInformationID = "shopifyModal";
        private IWebElement EmailInput => DriverFactory.Driver.FindElement(By.XPath("//div[@class='section section--contact-information']//input[1]"));
        private IWebElement NameInput => DriverFactory.Driver.FindElement(By.XPath("//div[@data-address-field='last_name']//input"));
        private IWebElement SurnameInput => DriverFactory.Driver.FindElement(By.XPath("//div[@data-address-field='first_name']//input"));
        private IWebElement AdressInput => DriverFactory.Driver.FindElement(By.XPath("//div[@data-address-field='address1']//input"));
        private IWebElement CityInput => DriverFactory.Driver.FindElement(By.XPath("//div[@data-address-field='city']//input"));
        private IWebElement ZipCodeInput => DriverFactory.Driver.FindElement(By.XPath("//div[@data-address-field='zip']//input"));
        private IWebElement ContinueButton => DriverFactory.Driver.FindElement(By.XPath("//div[@class='step__footer']//button"));

        public void SwitchToPaymentInformationIFrame()
        {
            DriverFactory.Driver.SwitchTo().Frame(PaymentInformationID);
        }
        public void FillPaymentForm(string email, string name, string surname, string adress, string city, string zipcode)
        {
            EmailInput.SendKeys(email);
            NameInput.SendKeys(name);
            SurnameInput.SendKeys(surname);
            AdressInput.SendKeys(adress);
            CityInput.SendKeys(city);
            ZipCodeInput.SendKeys(zipcode);
            ContinueButton.Click();
        }

    }
}
