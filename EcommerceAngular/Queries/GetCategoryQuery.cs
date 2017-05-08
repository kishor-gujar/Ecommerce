using System.Threading.Tasks;
using EcommerceData.Data;
using EcommerceData.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAngular.Queries
{
    public class GetCategoryQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public GetCategoryQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Category> Execute(string id)
        {
            var post = await _context.Products.SingleOrDefaultAsync(x => x.Id == id);

            return post?.Adapt<Category>(_typeAdapterConfig);
        }
    }
}