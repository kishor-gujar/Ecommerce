using Microsoft.Extensions.ObjectPool;

namespace EcommerceData.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Ssl { get; set; } 
    }
}