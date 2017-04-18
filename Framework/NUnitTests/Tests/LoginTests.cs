using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Framework.BusinessObjects;
using Framework.UI.Pages;
using NUnitTests.DataSources;

namespace NUnitTests.Tests
{

    [TestFixture]
    public class LoginTests : BaseTest
    {
        private LoginPage loginPage = new LoginPage();

        [Test, TestCaseSource(typeof(UsersDataSources), nameof(UsersDataSources.TestCaseWithUsers))]
        public void NegativeLoginTest(string email, string password)
        {
            loginPage.NavigateHere();
            loginPage.LoginMyXtramile(email,password);
            Assert.IsTrue(loginPage.IsLoginFailedMessageDisplayed());
        }

    }
}
