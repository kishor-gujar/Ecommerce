using System;

namespace EcommerceData.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public Order Order { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}