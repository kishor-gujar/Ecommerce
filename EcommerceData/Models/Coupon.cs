using System;

namespace EcommerceData.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public char Type { get; set; }
        public decimal Discount { get; set; }
        public bool Logged { get; set; }
        public bool Shipping { get; set; }
        public decimal Total { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int UserTotal { get; set; }
        public string UserCustomer { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}