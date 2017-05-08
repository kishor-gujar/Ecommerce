using System;

namespace EcommerceData.Models
{
    public class TaxClass
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string  Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}