using EnsekUITestingSuite.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace EnsekUITestingSuite.PageObjects
{
    public class StepsBasePage
    {
        public TestDataProperties TestDataProperties;
        public TestContext TestContext;

        public StepsBasePage(TestDataProperties testDataProperties, TestContext testContext)
        {
            TestDataProperties = testDataProperties;
            TestContext = testContext;
        }

        public void BasePage()
        {

        }


    }
}
