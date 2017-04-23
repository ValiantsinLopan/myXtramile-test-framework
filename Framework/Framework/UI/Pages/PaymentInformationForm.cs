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

        public void SwitchToPaymentInformationIFrame()
        {
            DriverFactory.Driver.SwitchTo().Frame(PaymentInformationID);
        }
    }
}
