using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace EnsekUITestingSuite.Helpers
{
    public class WebDriverFactory
    {
        public TestContext _testContext;
        public static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        public static IWebDriver driver = null!;


        public WebDriverFactory(TestContext TestContext)
        {
            _testContext = TestContext;
        }

        public void GetWebDriverFromConfig()
        {

            var driverRequested = _testContext.Properties["WebDriver"]
                     ?? throw new InvalidOperationException("Driver is not populated in run settings file selected, cannot proceed");
            CreateWebDriver((string)driverRequested);

        }

        public static IWebDriver CreateWebDriver(string driverRequested)
        {
            //Setting all values to lower before passing down to avoid any mismatch.
            driverRequested = driverRequested.ToLower();
            switch (driverRequested)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    Drivers.Add(driverRequested, driver);
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    Drivers.Add(driverRequested, driver);

                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    Drivers.Add(driverRequested, driver);

                    break;

                //please note, not covered all drivers, just using examples.

                //setting chrome to default to have at least one available if all else fails
                default:
                    driver = new ChromeDriver();
                    break;
            }

            return driver;
        }

        public static void LoadApplication(string url)
        {
            driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
                Drivers[key].Dispose();
                Drivers.Remove(key);
            }
        }
    }
}
