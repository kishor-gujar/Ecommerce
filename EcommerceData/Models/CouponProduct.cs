namespace EcommerceData.Models
{
    public class CouponProduct
    {
        public int Id { get; set; }
        public Coupon Coupon { get; set; }
        public Product Product { get; set; }
    }
}