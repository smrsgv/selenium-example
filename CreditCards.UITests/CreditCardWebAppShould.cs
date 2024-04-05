using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace CreditCards.UITests
{
    public class CreditCardWebAppShould
    {
        const string HomeUrl = "http://localhost:44108/";
        const string HomeTitle = "Home Page - Credit Cards";


        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://localhost:44108/");

                Assert.Equal(HomeTitle, driver.Title);
                Assert.Equal(HomeUrl, driver.Url);
            }
    }
}
