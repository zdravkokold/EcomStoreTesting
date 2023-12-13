using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.ComparisonScreenPage
{
    public partial class ComparisonScreenPage
    {
        public void AssertProductInfoIsCorrect()
        {
            ProductInfo expectedProductInfo = ProductInfoFactory.CreateHTCTouchProduct();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedProductInfo.Price, GetCompareProductDetailsCell("Price", 1).Text, $"Price mismatch for Product 1. Expected: {expectedProductInfo.Price}, Actual: {GetCompareProductDetailsCell("Price", 1).Text}");
                Assert.AreEqual(expectedProductInfo.Model, GetCompareProductDetailsCell("Model", 1).Text, $"Model mismatch for Product 1. Expected: {expectedProductInfo.Model}, Actual: {GetCompareProductDetailsCell("Model", 1).Text}");
                Assert.AreEqual(expectedProductInfo.Brand, GetCompareProductDetailsCell("Brand", 1).Text, $"Brand mismatch for Product 1. Expected: {expectedProductInfo.Brand}, Actual: {GetCompareProductDetailsCell("Brand", 1).Text}");
                Assert.AreEqual(expectedProductInfo.Weight, GetCompareProductDetailsCell("Weight", 1).Text, $"Weight mismatch for Product 1. Expected: {expectedProductInfo.Weight}, Actual: {GetCompareProductDetailsCell("Weight", 1).Text}");
                Assert.AreEqual(expectedProductInfo.ProductName, GetCompareProductDetailsCell("Product", 1).Text, $"Product Name mismatch for Product 1. Expected: {expectedProductInfo.ProductName}, Actual: {GetCompareProductDetailsCell("Product", 1).Text}");
                Assert.AreEqual(expectedProductInfo.Availability, GetCompareProductDetailsCell("Availability", 1).Text, $"Availability mismatch for Product 1. Expected: {expectedProductInfo.Availability}, Actual: {GetCompareProductDetailsCell("Availability", 1).Text}");
            });
        }
    }
}
