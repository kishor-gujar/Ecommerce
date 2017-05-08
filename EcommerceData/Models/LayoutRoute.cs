namespace EcommerceData.Models
{
    public class LayoutRoute
    {
        public int Id { get; set; }
        public Layout Layout { get; set; }
        public Store Store { get; set; }
        public string Route { get; set; }   
    }
}