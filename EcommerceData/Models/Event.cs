using System;

namespace EcommerceData.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Trigger { get; set; }
        public string Action { get; set; }
        public bool Status { get; set; }
        public DateTime DateCreated { get; set; }
    }
}