using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Framework.Steps;
using NUnitTests.DataSources;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class RegistrationTests : BaseTest
    {
        private RegistrationSteps steps = new RegistrationSteps();

        [Test, TestCaseSource(typeof(UsersDataSources), nameof(UsersDataSources.TestCaseForRegistration))]
        public void Registration(string email, string password, string companyName, string name)
        {
            steps.RegisterNewUser(name,email,password,name);
            Assert.IsTrue(steps.CheckIsCreateUser(email, "admin@admin.com", "123456"));
        }

    }
}
