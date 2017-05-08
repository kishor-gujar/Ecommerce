using System;

namespace EcommerceData.Models
{
    public class Reward
    {
        public int id { get; set; }
        public ApplicationUser User { get; set; }
        public Order Order { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public DateTime DateCreated { get; set; }
    }
}