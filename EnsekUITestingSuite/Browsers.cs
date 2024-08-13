using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekUITestingSuite
{
    public class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser(string browserName)
        {
            browserName = browserName.ToLower();
            switch (browserName)
            {
                case "firefox":
                    if (Driver == null)
                    {
                        driver = new FirefoxDriver();
                        Drivers.Add("Firefox", driver);
                    }
                    break;

                case "ie":
                    if (Driver == null)
                    {
                        driver = new InternetExplorerDriver(@"C:\PathTo\IEDriverServer");
                        Drivers.Add("IE", driver);
                    }
                    break;

                case "chrome":
                    if (Driver == null)
                    {
                        driver = new ChromeDriver(@"C:\PathTo\CHDriverServer");
                        Drivers.Add("Chrome", driver);
                    }
                    break;
            }
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
    }
}
