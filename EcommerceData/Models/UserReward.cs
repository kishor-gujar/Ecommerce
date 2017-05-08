using System;
using System.Reflection.Metadata.Ecma335;

namespace EcommerceData.Models
{
    public class UserReward
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Order Order { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public DateTime  DateCreated { get; set; }
    }
}