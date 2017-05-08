using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;

namespace EcommerceAngular.Queries
{
    public class GetAllAttributeQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly PagedCollectionParameters _defaultPagingParameters;
        private readonly TypeAdapterConfig _typeAdapterConfig;
        private readonly string _endpoint;

        public GetAllAttributeQuery(
            ApplicationDbContext context,
            PagedCollectionParameters defaultPagingParameters,
            TypeAdapterConfig typeAdapterConfig,
            string endpoint)
        {
            _context = context;
            _defaultPagingParameters = defaultPagingParameters;
            _typeAdapterConfig = typeAdapterConfig;
            _endpoint = endpoint;
        }

        public Task<PagedCollection<Attribute>> Execute(PagedCollectionParameters parameters)
        {
            var collectionFactory = new PagedCollectionFactory<Attribute>(PlaceholderLink.ToCollection(_endpoint));

            return collectionFactory.CreateFrom(
                _context.Products.ProjectToType<Attribute>(_typeAdapterConfig),
                parameters.Offset ?? _defaultPagingParameters.Offset.Value,
                parameters.Limit ?? _defaultPagingParameters.Limit.Value);
        }
    }
}