using System;
using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public bool Notify { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
    }
}