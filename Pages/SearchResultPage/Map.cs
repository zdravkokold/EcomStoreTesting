using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.SearchResultPage
{
    public partial class SearchResultPage
    {        
        public IWebElement InvalidSearchParagraph => WaitAndFindElement(By.CssSelector("#entry_212469 > p"));

        public IWebElement ProductName => WaitAndFindElement(By.CssSelector(".product-thumb .title > a"));
    }
}
