using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.ObjectPool;

namespace EcommerceData.Models
{
    public class DownloadDescription
    {
        public int Id { get; set; }
        public Download Download { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}