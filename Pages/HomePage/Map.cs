using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement SearchField => WaitAndFindElement(By.CssSelector("#search input[type=text]"));

        public IWebElement SearchButton => WaitAndFindElement(By.CssSelector("#search > div.search-button > button"));

        public IWebElement CompareButton => WaitAndFindElement(By.CssSelector("#entry_217823 > a"));

        public IWebElement CartButton => WaitAndFindElement(By.CssSelector("#entry_217830 > a"));

        public IWebElement EditCartButton => WaitAndFindElement(By.CssSelector("#entry_217850 > a"));

        public IWebElement ProductName => WaitAndFindElement(By.CssSelector("#entry_212948 > h1"));

        public IWebElement Brand => WaitAndFindElement(By.CssSelector("#entry_212953 > ul > li:nth-child(1) > a"));

        public IWebElement Model => WaitAndFindElement(By.CssSelector("#entry_212953 > ul > li:nth-child(2) > span:nth-child(2)"));

        public IWebElement RewardPoints => WaitAndFindElement(By.CssSelector("#entry_212953 > ul > li:nth-child(3) > span:nth-child(2)"));

        public IWebElement Availability => WaitAndFindElement(By.CssSelector(".badge-success"));

        public IWebElement Price => WaitAndFindElement(By.CssSelector("#entry_212957 > div > div > h3"));

        public IWebElement AddToCartButton => WaitAndFindElement(By.CssSelector("#entry_212964 > button"));

        public IWebElement QuantityField => WaitAndFindElement(By.CssSelector(".remove-spin-button"));

        public IWebElement OptionsSelect => WaitAndFindElement(By.Id("input-option231-212958"));
    }
}
