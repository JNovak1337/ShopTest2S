using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahooAutomate
{
    public class CreateAccountPage
    {
        IWebDriver driver;
        By EmailAddress = By.Id("email_create"); 
        By CreateAnAccount = By.Id("SubmitCreate");
        By TitleSelect = By.Name("Mr.");
        By FirstName = By.Id("customer_firstname");
        By LastName = By.Id("customer_lastname");
        By Email = By.Id("email");
        By Password = By.Id("passwd");
        By DayOfBirth = By.Id("days");
        By MonthOfBirth = By.Id("months");
        By YearOfBirth = By.Id("years");
        By NewsletterCheckbox = By.Id("newsletter");
        By SpecialOffersCheckbox = By.Id("optin");
        By AddressFirstName = By.Id("firstname");
        By AddressLastName = By.Id("lastname");
        By AddressCompany = By.Id("company");
        By AddressName = By.Id("address1");
        By AddressLineTwo = By.Id("address2");
        By AddressCity = By.Id("city");
        By AddressStateSelect = By.Id("id_state");
        By AddressZipPostalCode = By.Id("postcode");
        By AddressCountrySelect = By.Id("id_country");
        By AdditionalInfo = By.Id("other");
        By HomePhone = By.Id("phone");
        By MobilePhone = By.Id("phone_mobile");
        By AliasFutureReference = By.Id("alias");
        By RegisterButton = By.Id("submitAccount");

        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NewEmail()
        {
            driver.FindElement(EmailAddress).SendKeys("mytestemail@email.cz");
        }
        public void SubmitNewCustomer()
        {
            driver.FindElement(CreateAnAccount).Click();
        }
        public void Title()
        {
            driver.FindElement(TitleSelect).Click();
        }
        public void CustomerFirstName()
        {
            driver.FindElement(FirstName).SendKeys("Jan");
        }
        public void CustomerLastName()
        {
            driver.FindElement(LastName).SendKeys("Novak");
        }
        public void CustomerEmail()
        {
            driver.FindElement(Email).SendKeys("mujemail@email.cz");
        }
        public void CustomerPassword()
        {
            driver.FindElement(Password).SendKeys("heslo");
        }
        public void CustomerDayOfB()
        {
            driver.FindElement(DayOfBirth).Click();
        }
        public void CustomerMonthOfB()
        {
            driver.FindElement(MonthOfBirth).Click();
        }
        public void CustomerYearOfB()
        {
            driver.FindElement(YearOfBirth).Click();
        }
        public void Newsletter()
        {
            driver.FindElement(NewsletterCheckbox).Click();
        }
        public void SpecialOffer()
        {
            driver.FindElement(SpecialOffersCheckbox).Click();
        }
        public void CustomerAddresFirstName()
        {
            driver.FindElement(AddressFirstName).SendKeys("Jan");
        }
        public void CustomerAddresLastName()
        {
            driver.FindElement(AddressLastName).SendKeys("Novak");
        }
        public void CustomerCompanyAddress()
        {
            driver.FindElement(AddressCompany).SendKeys("Actum Digital");
        }
        public void CustomerAddress()
        {
            driver.FindElement(AddressName).SendKeys("Adresa 239/01");
        }
        public void CustomerAddresLineTwo()
        {
            driver.FindElement(AddressLineTwo).SendKeys("Floor 8th, Apartment n.39");
        }
        public void CustomerCity()
        {
            driver.FindElement(AddressCity).SendKeys("Prague");
        }
        public void CustomerState()
        {
            driver.FindElement(AddressStateSelect).Click();
        }
        public void CustomerZipPostalCode()
        {
            driver.FindElement(AddressZipPostalCode).SendKeys("290 922");
        }
        public void CustomerCountry()
        {
            driver.FindElement(AddressCountrySelect).Click();
        }
        public void CustomerAdditionalInfo()
        {
            driver.FindElement(AdditionalInfo).SendKeys("Some important infomation here.");
        }
        public void CustomerHomePhone()
        {
            driver.FindElement(HomePhone).SendKeys("233 330 120");
        }
        public void CustomerMobilePhone()
        {
            driver.FindElement(MobilePhone).SendKeys("720 442 482");
        }
        public void CustomerReference()
        {
            driver.FindElement(AliasFutureReference).SendKeys("Address 123");
        }
        public void RegisterSubmit()
        {
            driver.FindElement(RegisterButton).Click();
        }
    }
}
