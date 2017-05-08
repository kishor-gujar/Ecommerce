using System;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using EcommerceData.Models;
using Mapster;

namespace EcommerceAngular.Queries
{
    public class CreateAttributeQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CreateAttributeQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Tuple<string, Models.Attribute>> Execute(AttributeCreateModel model)
        {
            var entry = _context.Attributes.Add(new EcommerceData.Models.Attribute()
            {
                AttributeGroup = new EcommerceData.Models.AttributeGroup
                {
                        
                }
            });

            await _context.SaveChangesAsync();

            return new Tuple<string, Models.Attribute>(
                entry.Entity.Id,
                entry.Entity.Adapt<Models.Attribute>(_typeAdapterConfig));
        }
    }
    
}