using System;

namespace EcommerceData.Models
{
    public class UserWishlist
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
    }
}