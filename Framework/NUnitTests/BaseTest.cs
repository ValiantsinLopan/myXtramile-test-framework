using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Framework.WebDriver;

namespace NUnitTests
{
    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public void BaseFixtureSetUp()
        {
            DriverFactory.InitDriver();
        }

        [OneTimeTearDown]
        public void BaseFixtureTearDown()
        {
            DriverFactory.CleanupDriver();
        }
    }
}


