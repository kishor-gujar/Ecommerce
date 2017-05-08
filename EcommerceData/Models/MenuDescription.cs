namespace EcommerceData.Models
{
    public class MenuDescription
    {
        public int Id { get; set; }
        public Menu Menu { get; set; }
        public Language Language{ get; set; }
        public string Name { get; set; }
    }
}