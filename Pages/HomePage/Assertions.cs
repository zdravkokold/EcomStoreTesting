using EcomStoreTesting.Pages.SearchResultPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.HomePage
{
    public partial class HomePage
    {
        public void AssertProductInfoInQuickViewIsCorrect()
        {
            ProductInfo expectedProductInfo = ProductInfoFactory.CreateAppleCinemaProduct();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedProductInfo.Price, Price.Text, $"Price mismatch. Expected: {expectedProductInfo.Price}, Actual: {Price.Text}");
                Assert.AreEqual(expectedProductInfo.Brand, Brand.Text, $"Brand mismatch. Expected: {expectedProductInfo.Brand}, Actual: {Brand.Text}");
                Assert.AreEqual(expectedProductInfo.Model, Model.Text, $"Model mismatch. Expected: {expectedProductInfo.Model}, Actual: {Model.Text}");
                Assert.AreEqual(expectedProductInfo.ProductName, ProductName.Text, $"Product Name mismatch. Expected: {expectedProductInfo.ProductName}, Actual: {ProductName.Text}");
                Assert.AreEqual(expectedProductInfo.RewardPoints, RewardPoints.Text, $"Reward Points mismatch. Expected: {expectedProductInfo.RewardPoints}, Actual: {RewardPoints.Text}");
                Assert.AreEqual(expectedProductInfo.Availability, Availability.Text, $"Availability mismatch. Expected: {expectedProductInfo.Availability}, Actual: {Availability.Text}");
            });
        }

        public void AssertProductQuantityEqualsTo(string quantity)
        {
            Assert.AreEqual(quantity, QuantityField.GetAttribute("value"), $"Quantity mismatch. Expected: {quantity}, Actual: {QuantityField.GetAttribute("value")}");
        }

        public void AssertProductSizeAndPrice()
        {
            Assert.AreEqual("Large (+$18.00)", SelectSize("Large"), "Selected size mismatch.");
            Assert.AreEqual("$140.00", Price.Text, "Price mismatch.");
        }
    }
}
