using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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
            driver.Url = ConfigurationManager.AppSettings["URL"];
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

        public IWebDriver GetDriver() 
        {
            return driver;
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}