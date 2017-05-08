using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAngular.Queries
{
    public class GetUserQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public GetUserQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<User> Execute(string id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == id);

            return user?.Adapt<User>(_typeAdapterConfig);
        }
    }
}
