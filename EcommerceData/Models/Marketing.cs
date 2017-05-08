using System;

namespace EcommerceData.Models
{
    public class Marketing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public int Clicks { get; set; }
        public DateTime DateCreated { get; set; }
    }
}