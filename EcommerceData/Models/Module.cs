using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class Module
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Setting { get; set; } 
    }
}