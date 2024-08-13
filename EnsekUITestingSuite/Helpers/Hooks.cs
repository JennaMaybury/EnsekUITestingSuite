using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace EnsekUITestingSuite.Helpers
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario(Order = 0)]
        public void FirstBeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriverFactory.CloseAllDrivers();
        }
    }
}