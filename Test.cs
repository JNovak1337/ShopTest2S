// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YahooAutomate
{
    [TestFixture]
    public class Test
    {
        public IWebDriver driver;
        [Test]
        public void AutomationPractice()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/index.php?controller=authentication&back=my-account";

            CreateAccountPage CreateAcc = new CreateAccountPage(driver);

            #region Creating Account Steps

            CreateAcc.NewEmail();
            CreateAcc.SubmitNewCustomer();
            CreateAcc.Title();
            CreateAcc.CustomerFirstName();
            CreateAcc.CustomerLastName();
            CreateAcc.CustomerEmail();
            CreateAcc.CustomerPassword();
            CreateAcc.CustomerDayOfB();
            CreateAcc.CustomerMonthOfB();
            CreateAcc.CustomerYearOfB();
            CreateAcc.Newsletter();
            CreateAcc.SpecialOffer();
            CreateAcc.CustomerAddresFirstName();
            CreateAcc.CustomerAddresLastName();
            CreateAcc.CustomerCompanyAddress();
            CreateAcc.CustomerAddress();
            CreateAcc.CustomerAddresLineTwo();
            CreateAcc.CustomerCity();
            CreateAcc.CustomerState();
            CreateAcc.CustomerZipPostalCode();
            CreateAcc.CustomerCountry();
            CreateAcc.CustomerAdditionalInfo();
            CreateAcc.CustomerHomePhone();
            CreateAcc.CustomerReference();
            Thread.Sleep(2000);
            CreateAcc.RegisterSubmit();

            #endregion

            driver.Quit();

        }
    }
}
