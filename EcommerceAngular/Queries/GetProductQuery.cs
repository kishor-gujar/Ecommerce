using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using EcommerceData.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Product = EcommerceAngular.Models.Product;

namespace EcommerceAngular.Queries
{
    public class GetProductQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public GetProductQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Product> Execute(string id)
        {
            var post = await _context.Products.SingleOrDefaultAsync(x => x.Id == id);

            return post?.Adapt<Product>(_typeAdapterConfig);
        }
    }
}
