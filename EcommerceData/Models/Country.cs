namespace EcommerceData.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IsoCode2 { get; set; }
        public string IsoCode3 { get; set; }
        public string AddressFormat { get; set; }
        public bool PostalCodeRequired { get; set; }
        public bool Status { get; set; }
    }
}