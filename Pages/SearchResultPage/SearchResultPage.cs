using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.SearchResultPage
{
    public partial class SearchResultPage : WebPage
    {
        public SearchResultPage(IWebDriver driver) : base(driver)
        {
        }

        protected override void WaitForPageToLoad()
        {
            WaitAndFindElement(By.CssSelector(".cart-icon"));
        }
    }
}
