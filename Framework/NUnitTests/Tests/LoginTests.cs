using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Framework.UI.Pages;

namespace NUnitTests.Tests
{

    [TestFixture]
    public class LoginTests : BaseTest
    {
        private LoginPage loginPage = new LoginPage();

        [Test]
        public void NegativeLoginTest()
        {
            loginPage.NavigateHere();
            loginPage.LoginMyXtramile("wsdfdw","tgerdwrfg");
            Assert.IsTrue(loginPage.IsLoginFailedMessageDisplayed());
        }

    }
}
