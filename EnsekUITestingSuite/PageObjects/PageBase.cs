using EnsekUITestingSuite.Helpers;
using SeleniumExtras.PageObjects;

namespace EnsekUITestingSuite.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriverFactory.driver, page);
            return page;
        }

        public static HomePage Home => GetPage<HomePage>();

        public static AccountRegistrationPage AccountRegistration => GetPage<AccountRegistrationPage>();
    }
}