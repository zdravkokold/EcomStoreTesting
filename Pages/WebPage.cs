using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages
{
    public abstract class WebPage
    {
        private const int WAIT_FOR_ELEMENT_TIMEOUT = 30;

        public WebPage(IWebDriver driver)
        {
            Driver = driver;
            WebDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(WAIT_FOR_ELEMENT_TIMEOUT));
        }

        protected IWebDriver Driver { get; set; }
        protected WebDriverWait WebDriverWait { get; set; }

        public void GoTo(string url)
        {
            Driver.Navigate().GoToUrl(url);
            WaitForPageToLoad();
        }

        protected virtual void WaitForPageToLoad()
        {
        }

        public IWebElement WaitAndFindElement(By locator)
        {
            return WebDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }

        public void WaitForAjax()
        {
            var js = (IJavaScriptExecutor)Driver;
            WebDriverWait.Until(wd => js.ExecuteScript("return jQuery.active").ToString() == "0");
        }
    }
}
