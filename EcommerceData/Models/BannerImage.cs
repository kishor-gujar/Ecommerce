using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class BannerImage
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public int SortOrder { get; set; }  
    }
}