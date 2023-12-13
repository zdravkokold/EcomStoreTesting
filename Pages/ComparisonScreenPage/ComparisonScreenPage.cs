using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.ComparisonScreenPage
{
    public partial class ComparisonScreenPage : WebPage
    {
        public ComparisonScreenPage(IWebDriver driver) : base(driver)
        {
        }

        protected override void WaitForPageToLoad()
        {
            WaitAndFindElement(By.CssSelector(".cart-icon"));
        }
    }
}
