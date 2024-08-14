using EnsekUITestingSuite.Helpers;
using EnsekUITestingSuite.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace EnsekUITestingSuite.Steps
{
    [Binding]
    public class UserAccountsStepDefinitions : StepsBasePage
    {
        public UserAccountsStepDefinitions(TestDataProperties testDataProperties, TestContext testContext) : base(testDataProperties, testContext)
        {
        }

        public void CreateAccountTestData(string dataValidation)
        {
            switch (dataValidation)
            {
                case "valid email":
                    TestDataProperties.UserName = "Jenna.lee100121993@gmail.com";
                    //ideally this gets set by runsettings for future proofing and avoid having data here.
                    break;
                case "valid password":
                    TestDataProperties.Password = "Password1!";
                    break;
                case "invalid username":
                    TestDataProperties.UserName = "Jenna.lee100121993";
                    break;

                case "invalid password length":
                    TestDataProperties.Password = "Pd1!";
                    break;
                case "invalid password upper":
                    TestDataProperties.Password = "password1!";
                    break;
                case "invalid password lower":
                    TestDataProperties.Password = "PASSWORD1!";
                    break;
                case "invalid password special char":
                    TestDataProperties.Password = "PASSwORD1";
                    break;

                case "invalid password number":
                    TestDataProperties.Password = "Password!";
                    break;
                case "empty":
                    TestDataProperties.UserName = string.Empty;
                    TestDataProperties.Password = string.Empty;
                    break;

            }

        }


        [When(@"User selects register button from the home page")]
        public void WhenUserSelectsRegisterButtonFromTheHomePage()
        {
            Page.Home.SelectRegister();
        }

        [Then(@"Registration page is displayed successfully")]
        public void ThenRegistrationPageIsDisplayedSuccessfully()
        {

        }

        [When(@"User enters a '([^']*)' email address")]
        public void WhenUserEntersAEmailAddress(string valid)
        {
            CreateAccountTestData(valid);

            Page.AccountRegistration.PopulateEmail(TestDataProperties.UserName!);


        }

        [When(@"User enters a '([^']*)' password")]
        public void WhenUserEntersAPassword(string valid)
        {
            CreateAccountTestData(valid);
            Page.AccountRegistration.PopulatePassword(TestDataProperties.Password);

        }

        [When(@"User confrims '([^']*)' password")]
        public void WhenUserConfrimsPassword(string valid)
        {
            switch (valid)
            {
                case "valid":
                    Page.AccountRegistration.PopulateConfirmPassword(TestDataProperties.Password);
                    break;
                case "invalid":
                    Page.AccountRegistration.PopulatePassword(string.Empty);
                    break;
            }
        }

        [When(@"Selects register button")]
        public void WhenSelectsRegisterButton()
        {
            Page.AccountRegistration.ClickRegisterButton();
        }

        [Then(@"User account is created successfully")]
        public void ThenUserAccountIsCreatedSuccessfully()
        {
          Assert.Fail();
            //ideally here would have an assert with a success banner - was getting a SQl error 

        }

        [Then(@"'([^']*)' error message is displayed")]
        public void ThenErrorMessageIsDisplayed(string errorExpected)
        {
            Page.AccountRegistration.ErrorValidation(errorExpected);

        }

    }
}
