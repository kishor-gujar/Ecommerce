namespace EcommerceData.Models
{
    public class ZoneToGeoLocation
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public Zone Zone { get; set; }
        public GeoZone GeoZone { get; set; }
    }
}