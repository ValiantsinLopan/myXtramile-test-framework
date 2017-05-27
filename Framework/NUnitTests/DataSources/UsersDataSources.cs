using System.Collections;
using NUnit.Framework;
using Framework.BusinessObjects;
using Framework.Config;
using Framework.Resources;


namespace NUnitTests.DataSources
{
    public class UsersDataSources
    {
        private static string UsersPath => $"{Configuration.SolutionPath}/{TestDataPaths.UsersPath}";
        private static string RegisterUsersPath => $"{Configuration.SolutionPath}/{TestDataPaths.RegisterUsersPath}";
        private static string JobsPath => $"{Configuration.SolutionPath}/{TestDataPaths.JobsPath}";
        public static IEnumerable TestCaseWithUsers()
        {
           var data = AllUsers.DeserialiseUsers(UsersPath);
            foreach(var user in data.Users)
            {
                yield return new TestCaseData(user.Email, user.Password);
            }
        }
        public static IEnumerable TestCaseForRegistration()
        {
            var data = AllUsers.DeserialiseUsers(RegisterUsersPath);
            foreach (var user in data.Users)
            {
                yield return new TestCaseData(user.Email, user.Password, user.CompanyName, user.Name);
            }
        }
        public static IEnumerable TestCaseForJobCreation()
        {
            var data = AllJobs.DeserialiseJobs(JobsPath);
            foreach (var job in data.jobs)
            {
                yield return new TestCaseData(job.Title, job.Type, job.Country, job.Category, job.Description,
                    job.Budget, job.BriefDescription, job.MediaType);
            }
        }

    }
}
