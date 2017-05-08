namespace EcommerceData.Models
{
    public class UserGroupDecription
    {
        public int Id { get; set; }
        public UserGroup UserGroup { get; set; }
        public Language Language { get; set; }
        public string Name { get; set; }
    }
}