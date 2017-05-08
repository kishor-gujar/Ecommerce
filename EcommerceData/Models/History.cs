namespace EcommerceData.Models
{
    public class History
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string Comment  { get; set; }
    }
}