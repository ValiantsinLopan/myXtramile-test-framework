using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Framework.Steps;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class RegistrationTests : BaseTest
    {
        private RegistrationSteps steps = new RegistrationSteps();

        [Test]
        public void Registration()
        {
            steps.RegisterNewUser("lopan","lopanauto@mailinator.com","qwerty","testing");
            Assert.IsTrue(steps.CheckIsCreateUser("lopanauto@mailinator.com", "admin@admin.com", "123456"));
        }

    }
}
