namespace EcommerceData.Models
{
    public class ManufatureToStore
    {
        public int Id { get; set; }
        public Manufacurer Manufacurer { get; set; }
        public Store Store { get; set; }
    }
}