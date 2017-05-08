using System;
using System.Reflection.Metadata.Ecma335;

namespace EcommerceData.Models
{
    public class VoucherHistory
    {
        public int Id { get; set; }
        public Voucher Voucher { get; set; }
        public Order Order { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}