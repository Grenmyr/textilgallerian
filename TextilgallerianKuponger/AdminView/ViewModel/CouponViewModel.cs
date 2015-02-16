using System;
using System.Collections.Generic;
using System.Linq;
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


        /// <summary>
        /// TODO: Use dict above! Use strict types!
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
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

        /// <summary>
        /// TODO: Needs comments
        /// </summary>
        /// <returns></returns>
        public int AmountOfPages()
        {
            var calculated = (Coupons.Count() / 10.0);

            return (int)(Math.Ceiling(calculated));
        }

        public int CurrentPage { get; set; }

        public IEnumerable<Coupon> FindCouponsByPage(int page)
        {
            return Coupons.OrderBy(c => c.Start).Skip((page) * 10).Take(10).ToList();
        }
    }
}