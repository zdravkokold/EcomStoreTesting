using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.SearchResultPage
{
    public partial class SearchResultPage
    {
        public void AssertSearchResultContains(string item)
        {
            Assert.IsTrue(ProductName.Text.Contains(item, StringComparison.InvariantCultureIgnoreCase), "Invalid product search query.");
        }

        public void AssertRandomProductsAppearWhenSearchingWithEmptyString()
        {
            Assert.IsTrue(ProductName.Displayed, "No products are displayed.");
        }

        public void AssertNoProductMatchesTheSearchCriteria()
        {
            string message = InvalidSearchParagraph.Text;
            Assert.AreEqual("There is no product that matches the search criteria.", message, "Search result message mismatch.");
        }
    }
}
