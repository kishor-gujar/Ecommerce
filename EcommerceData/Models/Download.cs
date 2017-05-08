using System;
using Microsoft.Extensions.ObjectPool;

namespace EcommerceData.Models
{
    public class Download
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}