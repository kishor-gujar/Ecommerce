using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAngular.Queries
{
    public class GetRewiewQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public GetRewiewQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Review> Execute(string id)
        {
            var post = await _context.Products.SingleOrDefaultAsync(x => x.Id == id);

            return post?.Adapt<Review>(_typeAdapterConfig);
        }
    }
}