using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnsekUITestingSuite.PageObjects
{
    public class AccountRegistrationPage
    {
        public string pathTemplate = "";

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailTextBox = null!;

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PasswordTextBox = null!;

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement ConfirmPasswordTextBox = null!;

        [FindsBy(How = How.CssSelector, Using = "div:nth-child(8) > div > input")]
        public IWebElement RegisterButton = null!;

        [FindsBy(How = How.CssSelector, Using = "div.text-danger.validation-summary-errors")]
        public IWebElement ErrorMessageLabel = null!;


        public void RegisterUser(string email, string? password, string? confirmPassword)
        {
            PopulateEmail(email);

            PopulatePassword(password);
            PopulateConfirmPassword(confirmPassword);
        }

        public void PopulateEmail(string email)
        {
            EmailTextBox.SendKeys(email);
        }

        public void PopulatePassword(string? password)
        {
            PasswordTextBox.SendKeys(password);
        }

        public void PopulateConfirmPassword(string? confirmPassword)
        {
            ConfirmPasswordTextBox.SendKeys(confirmPassword);
        }

        public void ClickRegisterButton()
        {
            RegisterButton.Click();
        }

        public void ErrorValidation(string message)
        {
            switch (message)
            {
                case "Invalid username":
                    Assert.IsTrue(ErrorMessageLabel.Text == "The Email field is not a valid e-mail address.");
                    break;
                case "Invalid password length":
                    Assert.IsTrue(ErrorMessageLabel.Text == "The Password must be at least 6 characters long.");
                    break;
                case "Invalid password lower":
                    Assert.IsTrue(ErrorMessageLabel.Text == "Passwords must have at least one lowercase ('a'-'z').");
                    break;
                case "Invalid password upper":
                    Assert.IsTrue(ErrorMessageLabel.Text == "Passwords must have at least one uppercase ('A'-'Z').");
                    break;
                case "invalid password special char":
                    Assert.IsTrue(ErrorMessageLabel.Text ==
                                  "Passwords must have at least one non letter or digit character.");
                    break;
                case "Invalid password number":
                    Assert.IsTrue(ErrorMessageLabel.Text == "Passwords must have at least one digit ('0'-'9').");
                    break;
                case "Null password":
                    Assert.IsTrue(ErrorMessageLabel.Text == "The Password field is required.");
                    break;
                case "Null email":
                    Assert.IsTrue(ErrorMessageLabel.Text == "The Email field is required.");
                    break;
            }
        }
    }
}
