using System;

namespace EcommerceData.Models
{
    public class OrderRecurringTransaction
    {
        public int Id { get; set; }
        public OrderRecurring OrderRecurring { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }   
    }
}