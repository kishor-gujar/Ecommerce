using System;
using System.Data.SqlClient;

namespace EcommerceData.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string Api { get; set; }
        public string SessionId { get; set; }
        public Product Product { get; set; }
        public Recurring Recurring { get; set; }
        public string Option { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }   
    }
}