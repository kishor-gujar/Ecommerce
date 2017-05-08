using System;

namespace EcommerceData.Models
{
    public class UserTransaction
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Order Order { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}