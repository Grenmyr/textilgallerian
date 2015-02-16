using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace AdminView.ViewModel
{
    public class CouponViewModel
    {
        public Dictionary<string, String> CouponTypes = new Dictionary<string, String>() 
        {
            {  "Tag X betala f�r Y", typeof ( BuyXProductsPayForYProducts).Name },
            {  "K�p X f� Y gratis", typeof (BuyProductXRecieveProductY).Name },
            {  "K�p f�r X:kr betala Y:kr", typeof ( TotalSumAmountDiscount).Name },
            {  "K�p f�r X:kr f� Y:% rabatt", typeof ( TotalSumPercentageDiscount).Name }
        };


        public BuyXProductsPayForYProducts BuyXPayForY { get; set; }
        public ProductCoupon ProductCoupon { get; set; }
        public int ClickCount { get; set; }
        public Coupon Coupon { get; set; }
        public IEnumerable<User> Users { get; set; }
        public User User { get; set; }

        public String  GetCouponName(string type)
        {
            switch (type)
            {
                case "BuyXProductsPayForYProducts":
                    return "K�p X, Betala f�r Y"; 

                case "BuyProductXRecieveProductY":
                    return "K�p produkt X, f� produkt Y";

                case "TotalSumAmountDiscount":
                    return "Rabatt i kr";

                case "TotalSumPercentageDiscount":
                    return "Rabatt i %";
                default:
                    return "Ok�nd";
            }
        }


        public IEnumerable<Coupon> Coupons { get; set; }

        public int AmountOfPages()
        {
            double calculated = (Coupons.Count() / 10.0);

            return (int)(Math.Ceiling(calculated));
        }

        public int CurrentPage { get; set; }

        public IEnumerable<Coupon> FindCouponsByPage(int page)
        {
            return Coupons.OrderBy(c => c.Start).Skip((page) * 10).Take(10).ToList();
        }
    }
}