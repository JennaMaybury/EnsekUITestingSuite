using EnsekUITestingSuite.Helpers;
using EnsekUITestingSuite.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;


namespace EnsekUITestingSuite.Steps
{
    [Binding]
    public class NavigateToHomePageStepDefinitions : StepsBasePage
    {
        public WebDriverFactory _WebDriverFactory;

        public NavigateToHomePageStepDefinitions(TestDataProperties testDataProperties, TestContext testContext, WebDriverFactory webDriverFactory)
            : base(testDataProperties, testContext)
        {
            _WebDriverFactory = webDriverFactory;
        }


        public void CreateTestData()
        {
            TestDataProperties = new TestDataProperties
            {
                Url = (string)(TestContext.Properties["uiUrl"]
                               ?? throw new InvalidOperationException("uiUrl is not populated in run settings file selected, cannot proceed"))
            };
        }

        [Given(@"User navigates to site via Url")]
        [When(@"User navigates to site via Url")]
        public void WhenUserNavigatesToSiteViaUrl()
        {
            CreateTestData();

            WebDriverFactory.CreateWebDriver("Chrome");
            WebDriverFactory.LoadApplication(TestDataProperties.Url!);
        }

        [Then(@"Web page is displayed")]
        public void ThenWebPageIsDisplayed()
        {
            Assert.AreEqual(TestDataProperties.Url, WebDriverFactory.driver.Url,  
                $"Expected URL {TestDataProperties.Url} did not match actual url");
            Assert.IsTrue(Page.Home.RegisterButton.Displayed && Page.Home.RegisterButton.Enabled);
        }
    }
}
