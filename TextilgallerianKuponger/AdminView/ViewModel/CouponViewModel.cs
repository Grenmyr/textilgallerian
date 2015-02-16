using System;
using System.Collections.Generic;
using Domain;
using Domain.Entities;

namespace AdminView.ViewModel
{
    public class CouponViewModel
    {
        public Dictionary<String, Types> CouponTypes = new Dictionary<String, Types>
        {
            {  "Tag X betala f�r Y", Types.BuyProductXRecieveProductY },
            {  "K�p X f� Y gratis", Types.BuyXProductsPayForYProducts},
            {  "K�p f�r X:kr betala Y:kr", Types.TotalSumAmountDiscount },
            {  "K�p f�r X:kr f� Y:% rabatt", Types.TotalSumPercentageDiscount }
        };

        public BuyXProductsPayForYProducts BuyXProductsPayForYProducts { get; set; }
        public BuyProductXRecieveProductY BuyProductXRecieveProductY { get; set; }
        public TotalSumAmountDiscount TotalSumAmountDiscount { get; set; }
        public TotalSumPercentageDiscount TotalSumPercentageDiscount { get; set; }
        public ProductCoupon ProductCoupon { get; set; }
        public Coupon Coupon { get; set; }

        public Types Type { get; set; }
        public Boolean CanBeCombined { get; set; }

        //public IEnumerable<User> Users { get; set; }
        //public User User { get; set; }
        //public IEnumerable<Coupon> Coupons { get; set; }
    }
}