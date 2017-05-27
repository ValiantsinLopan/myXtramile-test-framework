using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


using Framework.WebDriver;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Framework.UI.Pages
{
    public class CreateJobPage
    {
        private const string JobDescriptionIFrame = "job-description_ifr";
        private IWebElement JobTitle => DriverFactory.Driver.FindElement(By.XPath("//input[@name='jobTitle']"));
        private IWebElement JobType => DriverFactory.Driver.FindElement(By.XPath("//span[text()='Select job type']"));
        private IWebElement CountrySelectPopup => DriverFactory.Driver.FindElement(By.XPath("//span[text()='Select a country']"));
        private IWebElement CountryCategorySearchInput => DriverFactory.Driver.FindElement(By.XPath("//input[@class='select2-search__field']"));
        private IWebElement CategorySelectPopup => DriverFactory.Driver.FindElement(By.XPath("//span[text()='Select job type']"));
        private IWebElement NextButton => DriverFactory.Driver.FindElement(By.XPath("//a[@href='#next']"));
        private IWebElement PreviousButton => DriverFactory.Driver.FindElement(By.XPath("//a[@href='#previous']"));
        private IWebElement JobDescriptionField => DriverFactory.Driver.FindElement(By.XPath("html/body/p"));
        private IWebElement FinishButton => DriverFactory.Driver.FindElement(By.XPath("//a[@href='#finish']"));
        private IWebElement BudgetInput => DriverFactory.Driver.FindElement(By.XPath("//input[@id='ember2217']"));
        private IWebElement StartDate => DriverFactory.Driver.FindElement(By.XPath("//input[@id='datePicker1']"));
        private IWebElement BriefDescription => DriverFactory.Driver.FindElement(By.XPath("//textarea[@id='description']"));
        private IWebElement TodayDate => DriverFactory.Driver.FindElement(By.XPath("//td[@class=' ui - datepicker - week - end ui - datepicker - days - cell - over ui - datepicker - today']"));
        private IWebElement MediaButton => DriverFactory.Driver.FindElement(By.XPath("//button[@class='btn btn-danger btn-labeled']"));
        private IWebElement SaveMediaButton => DriverFactory.Driver.FindElement(By.XPath("//button[@id='saveButton']"));

        public void FillFirstForm(string title, string type, string country, string category)
        {
            Thread.Sleep(3000);
            //var wait = new WebDriverWait(DriverFactory.Driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//input[@name='jobTitle']")));
            JobTitle.SendKeys(title);
            JobType.Click();
            DriverFactory.Driver.FindElement(By.XPath($"//li[text()='{type}']")).Click();
            CountrySelectPopup.Click();
            CountryCategorySearchInput.SendKeys(country);
            CountryCategorySearchInput.SendKeys(Keys.Enter);
            CategorySelectPopup.Click();
            CountryCategorySearchInput.SendKeys(category);
            CountryCategorySearchInput.SendKeys(Keys.Enter);
            NextButton.Click();
        }

        public void FillSecondForm(string description)
        {
            DriverFactory.Driver.SwitchTo().Frame(JobDescriptionIFrame);
            JobDescriptionField.SendKeys(description);
            NextButton.Click();
        }

        public void FillThirdForm(string budget, string briefDescription, string category)
        {
            BudgetInput.SendKeys(budget);
            StartDate.Click();
            StartDate.SendKeys(Keys.Enter);
            BriefDescription.SendKeys(briefDescription);
            MediaButton.Click();
            ShooseMedia(category);
            FinishButton.Click();
        }
        public void ShooseMedia(string category)
        {
            var folder = DriverFactory.Driver.FindElement(By.XPath($"//descendant::span[text()='/{category}']"));
            Actions action = new Actions(DriverFactory.Driver);
            action.DoubleClick(folder);
            var firstImage = DriverFactory.Driver.FindElement(By.XPath($"//ul[@style='display: none; ']//span[@class='fancytree-title'][1]"));
            firstImage.Click();
            SaveMediaButton.Click();
        }
    }
}