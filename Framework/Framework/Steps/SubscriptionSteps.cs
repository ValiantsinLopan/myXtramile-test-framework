using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.UI.Backoffice;
using Framework.UI.Mailinator;
using Framework.UI.Pages;

namespace Framework.Steps
{
    public class SubscriptionSteps
    {
        private LoginPage loginPage = new LoginPage(); 
        private UI.Pages.MainPage mainPage = new UI.Pages.MainPage();
        private MyAccountPage myAccountPage = new MyAccountPage();
        private PaymentInformationForm paymentForm = new PaymentInformationForm();

        public void SubscribeMouthly(string email, string password, string name, string surname, string adress, string city, string zipcode)
        {
            loginPage.NavigateHere();
            loginPage.LoginMyXtramile(email, password);
            mainPage.GoToAccountSettingsPage();
            myAccountPage.ChooseSubscription();
            paymentForm.SwitchToPaymentInformationIFrame();
            paymentForm.FillPaymentForm(email, name, surname, adress, city, zipcode);
            paymentForm.ChooseBankDepositPayment();

        }
    }
}
