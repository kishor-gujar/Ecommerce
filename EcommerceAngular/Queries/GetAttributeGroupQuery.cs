﻿using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAngular.Queries
{
    public class GetAttributeGroupQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public GetAttributeGroupQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<AttributeGroup> Execute(string id)
        {
            var post = await _context.Products.SingleOrDefaultAsync(x => x.Id == id);

            return post?.Adapt<AttributeGroup>(_typeAdapterConfig);
        }
    }
}