namespace EcommerceData.Models
{
    public class InformationToLayout
    {
        public int Id { get; set; }
        public Information Information { get; set; }
        public Store Store { get; set; }
        public Layout Layout { get; set; }
    }
}