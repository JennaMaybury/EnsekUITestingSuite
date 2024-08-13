using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace EnsekUITestingSuite.PageObjects
{
    public class HomePage
    {
        public string pathTemplate = "";

        [FindsBy(How = How.CssSelector, Using = "ul:nth-child(1) > li:nth-child(1) > a")]
        public IWebElement HomeNavButton = null!;

        [FindsBy(How = How.CssSelector, Using = "ul:nth-child(1) > li:nth-child(2) > a")]
        public IWebElement AboutNavButton = null!;

        [FindsBy(How = How.CssSelector, Using = "ul:nth-child(1) > li:nth-child(3) > a")]
        public IWebElement ContactNavButton = null!;

        [FindsBy(How = How.Id, Using = "registerLink")]
        public IWebElement RegisterButton = null!;

        [FindsBy(How = How.Id, Using = "loginLink")]
        public IWebElement LogInrButton = null!;

        [FindsBy(How = How.Id, Using = "//*[text()='Buy energy »']")] 
        public IWebElement BuyEnergyButton = null!;

        [FindsBy(How = How.Id, Using = "//*[text()='Sell energy »']")]
        public IWebElement SellEnergyButton = null!;

        [FindsBy(How = How.Id, Using = "//*[text()='Learn more »']")]
        public IWebElement LearnMoreButton = null!;


        public void SelectRegister()
        {
           RegisterButton.Click();
            
        }

    }
}