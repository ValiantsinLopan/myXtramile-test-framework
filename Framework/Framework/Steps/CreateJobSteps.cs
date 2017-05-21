using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.UI.Pages;

namespace Framework.Steps
{
    public class CreateJobSteps
    {
        private LoginPage loginPage = new LoginPage();
        private MainPage mainPage = new MainPage();
        private CreateJobPage createJobPage = new CreateJobPage();

        public void Login(string email, string password)
        {
            loginPage.NavigateHere();
            loginPage.LoginMyXtramile(email, password);
        }

        public void CreateSimpleJob(string title, string type, string country,
            string category, string description, string budget, string briefDescription)
        {
            mainPage.AddNewJob();
            createJobPage.FillFirstForm(title,type,country,category);
            createJobPage.FillSecondForm(description);
            createJobPage.FillThirdForm(budget, briefDescription, category);
        }

    }
}
