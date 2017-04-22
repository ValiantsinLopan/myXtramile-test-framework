using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Framework.WebDriver;

namespace Framework.UI.Pages
{
    public class MyAccountPage
    {
        private IWebElement SubscriptionItem => DriverFactory.Driver.FindElement(By.XPath("//ul[@class='navigation navigation-main navigation-accordion']//a[@href='/myaccount/subscription']"));
        private IWebElement CampaignDepositItem => DriverFactory.Driver.FindElement(By.XPath("//ul[@class='navigation navigation-main navigation-accordion']//a[@href='/myaccount/deposit']"));
        private IWebElement StarterPlanMounthlyTryButton => DriverFactory.Driver.FindElement(By.XPath("//div[@class='grid-demo']//div[@class='row'][2]//button[@class='btn btn-primary '][1]"));

    }
}
