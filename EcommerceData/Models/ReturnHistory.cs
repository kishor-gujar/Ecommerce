namespace EcommerceData.Models
{
    public class ReturnHistory
    {
        public int Id { get; set; }
        public Return Return { get; set; }
        public ReturnStatus ReturnStatus { get; set; }
        public int Notify { get; set; }
        public string Comment { get; set; }
    }
}