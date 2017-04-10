using System;
using System.Collections.Concurrent;
using Framework.Config;
using Framework.Resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Framework.WebDriver
{
    public static class DriverFactory
    {
        private const string Chrome = "chrome";
        private const string Firefox = "firefox";
        private const string Ie = "ie";
        private const string Edge = "edge";
        private const string Remote = "remote";

        private static readonly ConcurrentDictionary<string, IWebDriver> DriversDictionary = new ConcurrentDictionary<string, IWebDriver>();
        private static string CurrentTest => TestContext.CurrentContext.Test.ClassName;

        public static void CleanupDriver() { Driver.Quit(); }

        public static WebDriverWait Wait(TimeSpan time) => new WebDriverWait(Driver, time);
        public static WebDriverWait Wait() => new WebDriverWait(Driver, Configuration.DefaultDriverWaitSeconds);

        public static IWebDriver Driver
        {
            get
            {
                IWebDriver driver;
                if (DriversDictionary.TryGetValue(CurrentTest, out driver)) return driver;
                InitDriver();

                return DriversDictionary[CurrentTest];
            }
        }

        public static void InitDriver()
        {
            DriversDictionary.TryAdd(CurrentTest, GetDriverInstance());
            Driver.Manage().Timeouts().ImplicitWait = Configuration.DefaultDriverWaitSeconds;
        }

        /// <summary>
        /// Creates driver specified by current test name
        /// </summary>
        /// <exception cref="InvalidOperationException">if driver with specified name wasn't found</exception>
        /// <returns></returns>
        private static IWebDriver GetDriverInstance()
        {
            switch (Configuration.CurrentBrowserName)
            {
                case Firefox:
                    {
                        return GetFirefoxDriver();
                    }
                case Ie:
                    {
                        return GetIeDriver();
                    }
                case Edge:
                    {
                        return GetEdgeDriver();
                    }
                case Remote:
                    {
                        return GetRemoteDriver();
                    }
                case Chrome:
                default:
                    {
                        return GetChromeDriver();
                    }
            }
        }

        private static IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return new ChromeDriver(Configuration.ChromeBinPath, options);
        }

        private static IWebDriver GetFirefoxDriver()
        {
            var options = new FirefoxOptions
            {
                UseLegacyImplementation = true
            };

            var service = FirefoxDriverService.CreateDefaultService(Configuration.FirefoxBinPath);
            var driver = new FirefoxDriver(service);
            driver.Manage().Window.Maximize();
            return driver;
        }

        private static IWebDriver GetEdgeDriver()
        {
            var service = EdgeDriverService.CreateDefaultService(Configuration.EdgeBinPath);
            var driver = new EdgeDriver(service);
            driver.Manage().Window.Maximize();
            return driver;
        }

        private static IWebDriver GetIeDriver()
        {
            var service = InternetExplorerDriverService.CreateDefaultService(Configuration.IeBinPath);
            var driver = new InternetExplorerDriver(service);
            driver.Manage().Window.Maximize();
            return driver;
        }

        private static IWebDriver GetRemoteDriver()
        {
            var capabilities = Configuration.LoadBrowserStackCapabilities();
            var driver = new RemoteWebDriver(new Uri(BrowserStack.URL), capabilities);
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
