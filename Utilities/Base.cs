using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CSharpSeleniumFramework.Utilities
{
    public class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            String ConfigBrowserName = ConfigurationManager.AppSettings["Browser"];
            InitBrowser(ConfigBrowserName);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";
            TestContext.WriteLine("Title of the Webpage " + driver.Title);
        }

        public void InitBrowser(String BrowserName)
        {
            switch (BrowserName.ToLower()) 
            {
                case "firefox":
                    driver = new FirefoxDriver();
                    break;

                case "edge":
                    driver = new EdgeDriver();
                    break;

                case "chrome":
                    driver = new ChromeDriver();
                    break;
            }
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}