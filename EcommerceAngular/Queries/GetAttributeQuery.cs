using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAngular.Queries
{
    public class GetAttributeQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public GetAttributeQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Attribute> Execute(string id)
        {
            var post = await _context.Products.SingleOrDefaultAsync(x => x.Id == id);

            return post?.Adapt<Attribute>(_typeAdapterConfig);
        }
    }
}