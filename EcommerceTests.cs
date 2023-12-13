using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using EcomStoreTesting.Pages.CartPage;
using EcomStoreTesting.Pages.HomePage;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WebDriverManager;
using EcomStoreTesting.Pages.ComparisonScreenPage;
using EcomStoreTesting.Pages.SearchResultPage;
using OpenQA.Selenium.Support.UI;
using System.Numerics;
using System.Xml.Linq;

namespace EcomStoreTesting
{
    [TestFixture]
    public class EcommerceTests
    {
        private static IWebDriver driver;
        private static HomePage homePage;
        private static CartPage cartPage;
        private static ComparisonScreenPage comparisonScreenPage;
        private static SearchResultPage searchResultPage;

        public EcommerceTests()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            comparisonScreenPage = new ComparisonScreenPage(driver);
            searchResultPage = new SearchResultPage(driver);
            cartPage = new CartPage(driver);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }        

        [Test]
        [Order(1)]
        [TestCase("iPhone")]
        [TestCase("ipod touch")]
        [TestCase("Apple Cinema 30\"")]
        public void SearchingExistingItemsWithValidSearchQuery(string word)
        {
            homePage.Load();
            homePage.SearchItem(word);
            searchResultPage.AssertSearchResultContains(word);
        }

        [Test]
        [Order(2)]
        [TestCase("1234")]
        [TestCase("knife")]
        [TestCase("!@<-_->?#")]
        public void SearchingWithInvalidSearchQuery(string word)
        {
            homePage.Load();
            homePage.SearchItem(word);
            searchResultPage.AssertNoProductMatchesTheSearchCriteria();
        }

        [Test]
        [Order(3)]
        [TestCase("")]
        [TestCase(" ")]
        public void SearchingWithEmptyString(string word)
        {
            homePage.Load();
            homePage.SearchItem(word);
            searchResultPage.AssertRandomProductsAppearWhenSearchingWithEmptyString();
        }

        [Test]
        [Order(4)]
        public void VerifyingComparedItemInformation()
        {
            homePage.Load();
            homePage.AddItemToCompare("htc");
            homePage.GoToComparisonScreen();
            comparisonScreenPage.AssertProductInfoIsCorrect();            
        }

        [Test]
        [Order(5)]
        public void VerifyingProductInformationInQuickView()
        {
            homePage.Load();
            homePage.OpenProductQuickViewById("42");
            homePage.AssertProductInfoInQuickViewIsCorrect();           
        }

        [Test]
        [Order(6)]
        public void ChangeItemQuantityFromQuickView()
        {
            homePage.Load();
            homePage.OpenProductQuickViewById("42");
            homePage.SetProductQuantityTo("4");
            homePage.AssertProductQuantityEqualsTo("4");
        }

        [Test]
        [Order(7)]
        public void ChangeItemSizeFromQuickView()
        {
            homePage.Load();
            homePage.OpenProductQuickViewById("42");
            homePage.SelectSize("Large");
            homePage.AssertProductSizeAndPrice();            
        }

        [Test]
        [Order(8)]
        public void AddItemToCartAndVerifyInformation()
        {
            homePage.Load();
            homePage.OpenProductQuickViewById("42");
            homePage.SelectSize("Large");
            homePage.SetProductQuantityTo("4");
            homePage.AddItemToCart();
            cartPage.ViewCart();
            cartPage.AssertProductAddedToCart();                   
        }
    }
}