using System;

namespace EcommerceData.Models
{
    public class UserActivity
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string Key { get; set; }

        public string Data { get; set; }

        public DateTime DateCreated { get; set; }
    }
}