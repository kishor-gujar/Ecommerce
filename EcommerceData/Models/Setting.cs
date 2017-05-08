namespace EcommerceData.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public Store Store { get; set; }
        public string Code { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Serialized { get; set; }
    }
}