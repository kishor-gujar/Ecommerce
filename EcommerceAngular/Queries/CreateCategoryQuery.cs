using System;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;

namespace EcommerceAngular.Queries
{
    public class CreateCategoryQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CreateCategoryQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Tuple<string, Category>> Execute(CategoryCreateModel model)
        {
            var entry = _context.Categories.Add(new EcommerceData.Models.Category
            {
                
            });

            await _context.SaveChangesAsync();

            return new Tuple<string, Category>(
                entry.Entity.Id,
                entry.Entity.Adapt<Category>(_typeAdapterConfig));
        }
    }
}