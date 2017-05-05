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
    public class RegistrationSteps
    {
        private LoginPage registrationPage = new LoginPage();
        
        private LoginBackofficePage loginBackOfficePage = new LoginBackofficePage();
        private UI.Backoffice.MainPage backMainPage = new UI.Backoffice.MainPage();
        private UsersPage usersPage = new UsersPage();
        public void RegisterNewUser(string name, string email, string password, string company)
        {
            registrationPage.NavigateForRegistration();
            registrationPage.RegisterUser(name, email, password, company);
            
            //mainPage.SwitchToAppMainPage();
            //mainPage.GoToAccountSettingsPage();
        }
        public bool CheckIsCreateUser(string email, string login, string password)
        {
            loginBackOfficePage.NavigateHere();
            loginBackOfficePage.LoginBackoffice(login, password);
            backMainPage.GoToUserList();
            usersPage.SearchByEmail(email);
            return usersPage.IsUserFound(email);
        }

    }
}
