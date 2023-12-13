using EcomStoreTesting.Pages.SearchResultPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.HomePage
{
    public partial class HomePage : WebPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void SearchItem(string item)
        {
            Load();
            WaitForPageToLoad();
            SearchField.Clear();
            SearchField.SendKeys(item);
            SearchButton.Click();
        }

        public IWebElement GetCompareButton()
        {
            return WaitAndFindElement(By.CssSelector(".btn-default.btn-compare"));
        }

        protected override void WaitForPageToLoad()
        {
            WaitAndFindElement(By.CssSelector(".cart-icon"));
        }

        public void Load()
        {
            GoTo("https://ecommerce-playground.lambdatest.io/");
            WaitForPageToLoad();
        }

        public void GoToComparisonScreen()
        {
            CompareButton.Click();
            WaitForAjax();
        } 

        public void OpenProductQuickViewById(string id)
        {
            string script = $"document.querySelector('.quick-view-{id}').click()";
            ((IJavaScriptExecutor)Driver).ExecuteScript(script);
            WaitForAjax();
        }

        public void AddItemToCompare(string item)
        {
            SearchItem(item);
            WaitAndFindElement(By.CssSelector(".product-thumb .title > a")).Click();
            GetCompareButton().Click();
        }

        public void SetProductQuantityTo(string quantity)
        {
            QuantityField.Clear();
            QuantityField.SendKeys(quantity);
        }

        public void AddItemToCart() => AddToCartButton.Click();

        public string SelectSize(string size)
        {
            SelectElement dropDown = new SelectElement(OptionsSelect);
            dropDown.SelectByText(size, true);
            return dropDown.SelectedOption.Text;
        }
    }
}
