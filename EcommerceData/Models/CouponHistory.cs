using System;

namespace EcommerceData.Models
{
    public class CouponHistory
    {
        public int Id { get; set; }
        public Coupon Coupon { get; set; }
        public Order Order { get; set; }
        public ApplicationUser User { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}