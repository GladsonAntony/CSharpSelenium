using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumFramework.Utilities
{
    public class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupBrowser()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://rahulshettyacademy.com/seleniumPractise/#/offers";
            TestContext.WriteLine("Title of the Webpage " + driver.Title);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}