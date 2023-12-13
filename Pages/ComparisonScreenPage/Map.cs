using AngleSharp.Io;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.ComparisonScreenPage
{
    public partial class ComparisonScreenPage
    {           
        public IWebElement GetCompareProductDetailsCell(string cellName, int index)
        {
            return WaitAndFindElement(By.XPath($"//table/tbody/tr/td[text()='{cellName}']/following-sibling::td[{index}]"));
        }
    }
}
