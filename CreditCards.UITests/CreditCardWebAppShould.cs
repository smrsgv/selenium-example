using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace CreditCards.UITests
{
    public class CreditCardWebAppShould
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:44108/");
            }
        }
    }
}
