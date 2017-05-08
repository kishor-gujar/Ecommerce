namespace EcommerceData.Models
{
    public class Description
    {
        public int Id { get; set; }
        public UserGroup Group { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
        public string DescriptionText { get; set; }
    }
}