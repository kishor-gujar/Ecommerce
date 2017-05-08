using System;

namespace EcommerceData.Models
{
    public class UserSearch
    {
        public int Id { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Keyword { get; set; }
        public Category Category { get; set; }
        public bool SubCategory { get; set; }
        public bool Decription { get; set; }
        public int Products { get; set; }
        public DateTime DateCreated { get; set; }
    }
}