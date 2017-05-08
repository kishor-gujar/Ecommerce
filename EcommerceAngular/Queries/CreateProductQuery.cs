using System;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using EcommerceData.Models;
using Mapster;
using Product = EcommerceAngular.Models.Product;

namespace EcommerceAngular.Queries
{
    public class CreateProductQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CreateProductQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Tuple<string, Product>> Execute(ProductCreateModel model)
        {
            var entry = _context.Products.Add(new EcommerceData.Models.Product()
            {
                WeightClass = model.WeightClass,
                Quantity = model.Quantity,
                DateAvailable = model.DateAvailable,
                DateUpdated = DateTime.UtcNow,
                DateCreated = DateTime.UtcNow,
            });

            await _context.SaveChangesAsync();

            return new Tuple<string, Product>(
                entry.Entity.Id,
                entry.Entity.Adapt<Product>(_typeAdapterConfig));
        }
    }
}
