namespace EcommerceData.Models
{
    public class OrderVoucher
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Voucher Voucher { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public VoucherTheme VoucherTheme { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
    }
}