using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CSharpSeleniumFramework.PageObjects
{
    public class LoginPageObjects
    {
        private IWebDriver driver;
        public LoginPageObjects(IWebDriver driver) 
        { 
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        [CacheLookup]
        private IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "signInBtn")]
        [CacheLookup]
        private IWebElement signIn;

        [FindsBy(How = How.CssSelector, Using = "a.blinkingText")]
        [CacheLookup]
        private IWebElement freeAccessToInterviewquesresumeassistancematerial;

        [FindsBy(How = How.Id, Using = "terms")]
        [CacheLookup]
        private IWebElement iAgreeToTheTerms;

        public IWebElement getUserName()
        {
            return username;
        }

        public IWebElement getPassword()
        {
            return password;
        }

        public IWebElement getSignInButton()
        {
            return signIn;
        }

        public IWebElement getAgreeTerms()
        {
            return iAgreeToTheTerms;
        }

        public LoginPageObjects enterUserName(String userName)
        {
            username.SendKeys(userName);
            return this;
        }

        public LoginPageObjects enterPassword(String passwordText) 
        {
            password.SendKeys(passwordText);
            return this;
        }

        public LoginPageObjects clickOnSignInButton() 
        { 
            signIn.Click();
            return this;
        }

        public LoginPageObjects clickOnAgreeTerms()
        {
            iAgreeToTheTerms.Click();
            return this;
        }
    }
}
