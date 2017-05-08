namespace EcommerceData.Models
{
    public class CustomFieldUserGroup   
    {
        public int Id { get; set; }
        public UserGroup UserGroup { get; set; }
        public bool Required { get; set; }
    }
}