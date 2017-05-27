using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.UI.Pages;
using Framework.Steps;
using Framework.Tools;
using NUnitTests.DataSources;
using NUnit.Framework;

namespace NUnitTests.Tests
{
    [TestFixture]
    public class CreateJobTests : BaseTest
    {
        private CreateJobSteps steps = new CreateJobSteps();
        [Test, TestCaseSource(typeof(UsersDataSources), nameof(UsersDataSources.TestCaseForJobCreation))]
        public void CreateSimpleJob(string title, string type, string country, string category, string description,
            string budget, string briefdescription, string mediatype)
        {
            title = title + NameGenerator.CurrentDateTime();
            steps.Login("lopan@mailinator.com","123456");
            steps.CreateSimpleJob(title, type, country, category, description, budget,
                briefdescription);
        }
    }
}
