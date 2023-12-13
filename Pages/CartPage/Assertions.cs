using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting.Pages.CartPage
{
    public partial class CartPage
    {
        public void AssertProductAddedToCart()
        {
            ProductInfo expectedProductInfo = ProductInfoFactory.CreateAppleCinemaWithQuantityOf4();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedProductInfo.Model, Model.Text, $"Model mismatch. Expected: {expectedProductInfo.Model}, Actual: {Model.Text}");
                Assert.AreEqual(expectedProductInfo.TotalPrice, TotalPrice.Text, $"TotalPrice mismatch. Expected: {expectedProductInfo.TotalPrice}, Actual: {TotalPrice.Text}");
                Assert.AreEqual(expectedProductInfo.Price, UnitPrice.Text, $"UnitPrice mismatch. Expected: {expectedProductInfo.Price}, Actual: {UnitPrice.Text}");
                Assert.AreEqual(expectedProductInfo.ProductName, ProductName.Text, $"ProductName mismatch. Expected: {expectedProductInfo.ProductName}, Actual: {ProductName.Text}");
                Assert.AreEqual(expectedProductInfo.Quantity, Quantity.GetAttribute("value"), $"Quantity mismatch. Expected: {expectedProductInfo.Quantity}, Actual: {Quantity.GetAttribute("value")}");
                Assert.IsTrue(RewardPoints.Text.Contains(expectedProductInfo.RewardPoints), $"RewardPoints mismatch. Expected: {expectedProductInfo.RewardPoints}, Actual: {RewardPoints.Text}");
                Assert.IsTrue(Size.Text.Contains(expectedProductInfo.Size), $"Size mismatch. Expected: {expectedProductInfo.Size}, Actual: {Size.Text}");
            });
        }
    }
}
