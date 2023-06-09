﻿using CSharpSeleniumFramework.PageObjects;
using CSharpSeleniumFramework.Utilities;
using NUnit.Framework;

namespace CSharpSeleniumFramework.Tests
{
    [Parallelizable(ParallelScope.All)]
    public  class LoginPageTest : Base
    {
        [Test, Category("Smoke")]
        public void LoginPageDemo()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects(GetDriver());

            loginPageObjects
                .getUserName()
                .SendKeys("Gladson Antony");
            Thread.Sleep(5000);
        }

        [TestCase("Gladson Antony", "Password")]
        [TestCase("rahulshettyacademy", "learning")]
        public void LoginPageDemo2(String username, String password)
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects(GetDriver());

            loginPageObjects
                .enterUserName(username)
                .enterPassword(password);
            Thread.Sleep (5000);
        }

        [Test, Category("Smoke")]
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

        [TestCaseSource("AddTestDataConfig")]
        //[Parallelizable(ParallelScope.All)]
        public void LoginPageDemo4(String username, String password)
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects(GetDriver());

            loginPageObjects
                .loginToTheWebsite(username,password)
                .WaitForPageDisplay()
                .getProducts()
                .clickOnCheckOutButton();
            Thread.Sleep(5000);
        }

        public static IEnumerable<TestCaseData> AddTestDataConfig()
        {
            yield return new TestCaseData("rahulshettyacademy", "learning");            
            yield return new TestCaseData(getDataParser().extractData("username"), getDataParser().extractData("password"));
            yield return new TestCaseData(getDataParser().extractData("username_wrong"), getDataParser().extractData("password_wrong"));
        }
    }
}
