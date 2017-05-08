using System;

namespace EcommerceData.Models
{
    public class UserOnline
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Url { get; set; }
        public string Referer { get; set; }
        public DateTime DateCreated { get; set; }
    }
}