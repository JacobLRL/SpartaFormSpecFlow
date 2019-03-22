using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Faker;

namespace SpartaGlobalFormSpecFlowTest
{
    [Binding]
    public class SpartaGlobalFormSteps
    {
        private IWebDriver _driver;
        private SpartaFormPage _spartaFormPage;

        [Given(@"I am on the form page")]
        public void GivenIAmOnTheFormPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _spartaFormPage = SpartaFormPage.NavigateTo(_driver);
        }

        [Given(@"I enter the valid details in all the required fields")]
        public void GivenIEnterTheValidDetailsInAllTheRequiredFields()
        {
            _spartaFormPage.FirstName = Name.First();
            _spartaFormPage.LastName = Name.Last();
            _spartaFormPage.Age = RandomNumber.Next(99).ToString();
            _spartaFormPage.ClickGender(new Random(2).Next() < 1);
            _spartaFormPage.Degree = Name.FullName();
            _spartaFormPage.Address = Address.StreetAddress();
            _spartaFormPage.City = Address.City();
            _spartaFormPage.Postcode = Address.UkPostCode();
            _spartaFormPage.Email = Internet.Email();
            _spartaFormPage.Phone = Phone.Number();
            _spartaFormPage.ClickStream(new Random(2).Next() < 1);
            _spartaFormPage.ClickTerms();

            _spartaFormPage.ClickSignin();
        }
        
        [When(@"I press sign in")]
        public void WhenIPressSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on the correct page")]
        public void ThenIShouldBeOnTheCorrectPage()
        {
            ScenarioContext.Current.Pending();
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            //_driver.Dispose();
        }
    }
}
