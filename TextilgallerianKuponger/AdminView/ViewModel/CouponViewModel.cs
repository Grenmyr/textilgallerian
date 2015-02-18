using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace AdminView.ViewModel
{
    public class CouponViewModel
    {
        public Dictionary<String, String> CouponTypes = new Dictionary<String, String>
        {
            {typeof (BuyProductXRecieveProductY).FullName, "Tag X betala f�r Y"},
            {typeof (BuyXProductsPayForYProducts).FullName, "K�p X f� Y gratis"},
            {typeof (TotalSumAmountDiscount).FullName, "K�p f�r X:kr betala Y:kr"},
            {typeof (TotalSumPercentageDiscount).FullName, "K�p f�r X:kr f� Y:% rabatt"}
        };

        public String Type { get; set; }
        public Boolean CanBeCombined { get; set; }
        public IEnumerable<Coupon> Coupons { get; set; }
        public int CurrentPage { get; set; }
        public Dictionary<String, String> Parameters { get; set; }

        /// <summary>
        ///     TODO: Needs comments
        /// </summary>
        /// <returns></returns>
        public int AmountOfPages()
        {
            var calculated = (Coupons.Count()/10.0);

            return (int) (Math.Ceiling(calculated));
        }
    }
}