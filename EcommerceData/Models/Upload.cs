using System;

namespace EcommerceData.Models
{
    public class Upload
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Code { get; set; }
        public DateTime  DateCreated { get; set; }
    }
}