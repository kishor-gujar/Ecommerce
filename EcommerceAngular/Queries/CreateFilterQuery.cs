using System;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;

namespace EcommerceAngular.Queries
{
    public class CreateFilterQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CreateFilterQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Tuple<string, Filter>> Execute(FilterCreateModel model)
        {
            var entry = _context.Filters.Add(new EcommerceData.Models.Filter()
            {
                
            });

            await _context.SaveChangesAsync();

            return new Tuple<string, Filter>(
                entry.Entity.Id,
                entry.Entity.Adapt<Filter>(_typeAdapterConfig));
        }
    }
}