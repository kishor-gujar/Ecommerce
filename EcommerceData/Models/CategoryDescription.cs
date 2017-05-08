namespace EcommerceData.Models
{
    public class CategoryDescription
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDesctiption { get; set; }
        public string MetaKeyWord { get; set; }

    }
}