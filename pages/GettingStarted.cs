using OpenQA.Selenium;

namespace SeleniumFramework.pages
{
    class GettingStarted
    {
        private IWebDriver driver = null;

        private By pageImageClass = By.XPath("//h1[contains(text(),'List of features')]");
        private By backToTop = By.ClassName("back-to-top");
        private By legalLink = By.LinkText("Legal");
        public GettingStarted(IWebDriver d)
        {
            driver = d;

        }

    }
}
