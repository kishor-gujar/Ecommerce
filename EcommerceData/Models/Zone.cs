namespace EcommerceData.Models
{
    public class Zone
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Status { get; set; }
    }
}