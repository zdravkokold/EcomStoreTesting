using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomStoreTesting
{
    public static class ProductInfoFactory
    {
        public static ProductInfo CreateAppleCinemaProduct()
        {
            return new ProductInfo()
            {
                ProductName = "Apple Cinema 30\"",
                Brand = "Apple",
                Model = "Product 15",
                RewardPoints = "100",
                Availability = "In Stock",
                Price = "$122.00",
            };
        }

        public static ProductInfo CreateHTCTouchProduct()
        {
            return new ProductInfo()
            {
                ProductName = "HTC Touch HD",
                Price = "$146.00",
                Model = "Product 1",
                Brand = "HTC",
                Availability = "In Stock",
                Weight = "146.40g",
            };
        }

        public static ProductInfo CreateAppleCinemaWithQuantityOf4()
        {
            return new ProductInfo()
            {
                ProductName = "Apple Cinema 30\"",
                Size = "Large",
                RewardPoints = "400",
                Model = "Product 15",
                Quantity = "4",
                Price = "$140.00",
                TotalPrice = "$560.00",
            };
        }
    }
}
