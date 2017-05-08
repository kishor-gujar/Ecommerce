using Microsoft.EntityFrameworkCore.Design.Internal;

namespace EcommerceData.Models
{
    public class InformationDescription
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
    }
}