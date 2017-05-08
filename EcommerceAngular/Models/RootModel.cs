
using EcommerceAngular.Controllers;

namespace EcommerceAngular.Models
{
    public class RootModel : Resource
    {
        public RootModel()
        {
            Meta = new PlaceholderLink()
            {
                Href = "/",
                Method = "GET"
            };
        }
        
        public ILink Products { get; set; } = PlaceholderLink.ToCollection(ProductController.Endpoint);
    }
}
