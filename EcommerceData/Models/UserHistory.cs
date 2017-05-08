using System;
using Microsoft.AspNetCore.Hosting;

namespace EcommerceData.Models
{
    public class UserHistory
    {
        public int Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
    }
}