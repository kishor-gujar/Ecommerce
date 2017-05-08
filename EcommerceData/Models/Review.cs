using System;

namespace EcommerceData.Models
{
    public class Review
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}