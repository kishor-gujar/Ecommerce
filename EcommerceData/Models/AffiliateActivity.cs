using System;

namespace EcommerceData.Models
{
    public class AffiliateActivity
    {
        public int Id { get; set; }
        public Affiliate Affiliate { get; set; }
        public int Key { get; set; }
        public string Data { get; set; }
        public DateTime DateCreated { get; set; }
    }
}