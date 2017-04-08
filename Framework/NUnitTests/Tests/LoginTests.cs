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
        private LoginPage _loginPage = new LoginPage();

        [Test]
        public void NegativeLoginTest()
        {
            _loginPage.NavigateHere();
            _loginPage.LoginMyXtramile("wsdfdw","tgerdwrfg");
            Assert.IsFalse(_loginPage.IsLoginFailedMessageDisplayed());
        }

    }
}
