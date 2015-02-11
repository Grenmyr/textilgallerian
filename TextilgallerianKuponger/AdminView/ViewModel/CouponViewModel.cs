using System.Collections.Generic;
using Domain.Entities;
using System;

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

        public List<Coupon> Coupon1
        {
            get
            {
                return new List<Coupon>{
                        new BuyProductXRecieveProductY
                        {
                            Code = "xmas14",
                            Start = System.DateTime.Now,
                            End = System.DateTime.Now.AddDays(1)
                            
                        },
                        new TotalSumAmountDiscount
                        {
                            Code = "jul",
                            Start = System.DateTime.Now,
                            End = System.DateTime.Now.AddDays(1)                            
                        },
                        new TotalSumPercentageDiscount
                        {
                            Code = "p�sk",
                            Start = System.DateTime.Now,
                            End = System.DateTime.Now.AddDays(1)    
                        }
                    };
            }
        }

        public List<User> Users1
        {
            get
            {
                return new List<User>{
                    new User
                    {
                    Email = "Anna.Bok@mail.se",
                    },
                    new User
                    {
                    Email = "Roger.P@mail.com"
                    },
                    new User
                    {
                    Email = "Brains@mail.com"
                    }
                };
            }
        }

        public IEnumerable<Coupon> Coupons { get; set; }
    }
}