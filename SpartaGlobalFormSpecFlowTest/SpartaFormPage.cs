using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SpartaGlobalFormSpecFlowTest
{
    public class SpartaFormPage
    {
        private readonly IWebDriver _driver;

        // Page factory objects
        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement _firstName;
        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement _lastName;
        [FindsBy(How = How.CssSelector, Using = "input[type='number']")]
        private IWebElement _age;
        [FindsBy(How = How.CssSelector, Using = "label[for='customRadioInline1']")]
        private IWebElement _genderMale;
        [FindsBy(How = How.CssSelector, Using = "label[for='customRadioInline2']")]
        private IWebElement _genderFemale;
        [FindsBy(How = How.CssSelector, Using = "input[placeholder='Enter Degree']")]
        private IWebElement _degree;
        [FindsBy(How = How.Id, Using = "inputAddress")]
        private IWebElement _address;
        [FindsBy(How = How.Id, Using = "inputCity")]
        private IWebElement _city;
        [FindsBy(How = How.Id, Using = "inputPostcode")]
        private IWebElement _postcode;
        [FindsBy(How = How.Id, Using = "inputemailaddress")]
        private IWebElement _emailAddress;
        [FindsBy(How = How.Id, Using = "exampleFormControlInput1")]
        private IWebElement _phone;
        [FindsBy(How = How.CssSelector, Using = "label[for='streamRadioInline1'")]
        private IWebElement _stream1;
        [FindsBy(How = How.CssSelector, Using = "label[for='streamRadioInline2'")]
        private IWebElement _stream2;
        [FindsBy(How = How.Id, Using = "terms")]
        private IWebElement _terms;
        [FindsBy(How = How.ClassName, Using = "btn")]
        private IWebElement _signin;

        private const string PageUri = @"http://automation-form.spartaglobal.education/";

        public SpartaFormPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public static SpartaFormPage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);
            return new SpartaFormPage(driver);
        }

        public string FirstName
        {
            set
            {
                _firstName.SendKeys(value);
            }
        }

        public string LastName
        {
            set
            {
                _lastName.SendKeys(value);
            }
        }

        public string Age
        {
            set
            {
                _age.SendKeys(value);
            }
        }

        public void ClickSignin() {
            _signin.Click();
        }

        public void ClickGender(bool gender) {
            if (gender) _genderMale.Click();
            else _genderFemale.Click();
        }

        public string Degree
        {
            set {
                _degree.SendKeys(value);
            }
        }

        public string Address
        {
            set
            {
                _address.SendKeys(value);
            }
        }

        public string City
        {
            set
            {
                _city.SendKeys(value);
            }
        }

        public string Postcode
        {
            set
            {
                _postcode.SendKeys(value);
            }
        }

        public string Email
        {
            set
            {
                _emailAddress.SendKeys(value);
            }
        }

        public string Phone
        {
            set
            {
                _phone.SendKeys(value);
            }
        }

        public void ClickStream(bool stream)
        {
            if (stream) _stream1.Click();
            else _stream2.Click();
        }
        //not working
        public void ClickTerms() {
            _terms.Click();
        }
    }
}
