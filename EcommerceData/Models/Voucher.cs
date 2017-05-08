using System;
using System.Reflection.Metadata.Ecma335;

namespace EcommerceData.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public string Code { get; set; }
        public string FormName { get; set; }
        public string FromEmail { get; set; }
        public string ToName { get; set; }
        public string ToEmail { get; set; }
        public VoucherTheme VoucherTheme { get; set; }
        public string Message { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
    }

}