using CSharpSeleniumFramework.PageObjects;
using CSharpSeleniumFramework.Utilities;

namespace CSharpSeleniumFramework.Tests
{
    public  class LoginPageTest : Base
    {
        [Test]
        public void LoginPageDemo()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects(GetDriver());

            loginPageObjects
                .getUserName()
                .SendKeys("Gladson Antony");
            Thread.Sleep(5000);
        }

        [Test]
        public void LoginPageDemo2()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects(GetDriver());

            loginPageObjects
                .enterUserName("Gladson Antony")
                .enterPassword("Gladson Antony");
            Thread.Sleep (5000);
        }

        [Test]
        public void LoginPageDemo3()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects(GetDriver());

            loginPageObjects
                .enterUserName("rahulshettyacademy")
                .enterPassword("learning")
                .clickOnAgreeTerms()
                .clickOnSignInButton();
            Thread.Sleep(5000);
        }

        [Test]
        public void LoginPageDemo4()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects(GetDriver());

            loginPageObjects
                .loginToTheWebsite("rahulshettyacademy", "learning")
                .WaitForPageDisplay()
                .getProducts()
                .clickOnCheckOutButton();
            Thread.Sleep(5000);
        }
    }
}
