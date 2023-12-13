using EcomStoreTesting.Pages.HomePage;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.CartPage
{
    public partial class CartPage : WebPage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }            
        
        protected override void WaitForPageToLoad()
        {
            WaitAndFindElement(By.CssSelector(".img-thumbnail"));
        }        

        public void ViewCart()
        {
            GoTo("https://ecommerce-playground.lambdatest.io/index.php?route=checkout/cart");
            WaitForPageToLoad();
        }
    }
}
