using EcommerceData.Models;
using Mapster;

namespace EcommerceAngular
{
    public class TypeMappings : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {

            config.ForType<Product, Models.Product>()
                .MapWith(src => new Models.Product
                {
                    Shipping = src.Shipping,
                   DateCreated = src.DateCreated
                });
            config.ForType<Attribute, Models.Attribute>()
                .MapWith(src => new Models.Attribute
                {

                });
            config.ForType<AttributeGroup, Models.Attribute>()
                .MapWith(src => new Models.Attribute
                {

                });
            config.ForType<Review, Models.Review>()
                .MapWith(src => new Models.Review
                    {
                        
                    });
        }
    }
}