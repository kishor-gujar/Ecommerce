using System;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using EcommerceData.Models;
using Mapster;

namespace EcommerceAngular.Queries
{
    public class CreateUserQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CreateUserQuery(ApplicationDbContext context, TypeAdapterConfig typeAdapterConfig)
        {
            _context = context;
            _typeAdapterConfig = typeAdapterConfig;
        }

        public async Task<Tuple<string, User>> Execute(UserCreateModel model)
        {
            var entry = _context.Users.Add(new ApplicationUser()
            {
                FirstName = model.FirstName,
                Email = model.Email,
                PasswordHash = model.Password
            });

            await _context.SaveChangesAsync();

            return new Tuple<string, User>(
                entry.Entity.Id,
                entry.Entity.Adapt<User>(_typeAdapterConfig));
        }
    }
}
