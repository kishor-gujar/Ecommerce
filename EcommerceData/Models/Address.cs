namespace EcommerceData.Models
{
    public class Address
    {
        public int Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public Zone Zone { get; set; }
        public string CoustomField { get; set; }
    }
}