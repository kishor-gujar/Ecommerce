using System;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;

namespace EcommerceAngular.Queries
{
    public class CreateAttributeGroupQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CreateAttributeGroupQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Tuple<string, AttributeGroup>> Execute(AttributeGroupCreateModel model)
        {
            var entry = _context.AttributeGroups.Add(new EcommerceData.Models.AttributeGroup
            {
               SortOrder = model.SortOrder,
            });

            await _context.SaveChangesAsync();

            return new Tuple<string, AttributeGroup>(
                entry.Entity.Id,
                entry.Entity.Adapt<AttributeGroup>(_typeAdapterConfig));
        }
    }
}