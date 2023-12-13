using AngleSharp.Browser.Dom;
using EcomStoreTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.CartPage
{
    public partial class CartPage
    {       
        public IWebElement ProductName => WaitAndFindElement(By.XPath("//td[@class='text-left']/a"));

        public IWebElement Size => WaitAndFindElement(By.XPath("//td[@class='text-left']/small[contains(text(), 'Size')]"));

        public IWebElement RewardPoints => WaitAndFindElement(By.XPath("//td[@class='text-left']/small[contains(text(), 'Reward Points')]"));

        public IWebElement Model => WaitAndFindElement(By.XPath("//table/thead/tr/th[text()='Model']/following::td[3]"));

        public IWebElement Quantity => WaitAndFindElement(By.XPath("//td[@class='text-left']/div/input[@type='text']"));

        public IWebElement TotalPrice => WaitAndFindElement(By.XPath("//table/thead/tr/th[text()='Total']/following::td[6]"));

        public IWebElement UnitPrice => WaitAndFindElement(By.XPath("//table/thead/tr/th[text()='Unit Price']/following::td[5]"));
    }
}