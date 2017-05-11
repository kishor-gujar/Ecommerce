using System;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;

namespace EcommerceAngular.Queries
{
    public class CreateReviewQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CreateReviewQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Tuple<string, Review>> Execute(RewiewCreateModel model)
        {
            var entry = _context.Reviews.Add(new EcommerceData.Models.Review
            {
                
            });

            await _context.SaveChangesAsync();

            return new Tuple<string, Review>(
                entry.Entity.Id,
                entry.Entity.Adapt<Review>(_typeAdapterConfig));
        }
    }
}