using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceData.Data;
using EcommerceData.Models;
using Mapster;
using Attribute = EcommerceAngular.Models.Attribute;

namespace EcommerceAngular.Queries
{
    public class GetAllCategoriesQuery
    {
        private readonly ApplicationDbContext _context;
        private readonly PagedCollectionParameters _defaultPagingParameters;
        private readonly TypeAdapterConfig _typeAdapterConfig;
        private readonly string _endpoint;

        public GetAllCategoriesQuery(
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

        public Task<PagedCollection<Models.Category>> Execute(PagedCollectionParameters parameters)
        {
            var collectionFactory = new PagedCollectionFactory<Models.Category>(PlaceholderLink.ToCollection(_endpoint));

            return collectionFactory.CreateFrom(
                _context.Products.ProjectToType<Models.Category>(_typeAdapterConfig),
                parameters.Offset ?? _defaultPagingParameters.Offset.Value,
                parameters.Limit ?? _defaultPagingParameters.Limit.Value);
        }
    }
}