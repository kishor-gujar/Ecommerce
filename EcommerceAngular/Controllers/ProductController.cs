using System.Linq;
using System.Threading.Tasks;
using EcommerceAngular.Models;
using EcommerceAngular.Queries;
using EcommerceData.Data;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EcommerceAngular.Controllers
{
    [Route(Endpoint)]
    public class ProductController : Controller
    {

        public const string Endpoint = "api/products";

            private readonly ApplicationDbContext _context;
            private readonly PagedCollectionParameters _defaultPagingOptions;
            private readonly TypeAdapterConfig _typeAdapterConfig;

            public ProductController(
                ApplicationDbContext context,
                IOptions<PagedCollectionParameters> defaultPagingOptions,
                TypeAdapterConfig typeAdapterConfig)
            {
                _context = context;
                _defaultPagingOptions = defaultPagingOptions.Value;
                _typeAdapterConfig = typeAdapterConfig;
            }

            [HttpGet]
            public async Task<IActionResult> Get(PagedCollectionParameters parameters)
            {
                var getAllQuery = new GetAllproductsQuery(_context, _defaultPagingOptions, _typeAdapterConfig, Endpoint);
                var results = await getAllQuery.Execute(parameters);

                // Attach form definitions for discoverability
                results.Forms = new[] { Form.FromModel<ProductCreateModel>(Endpoint, "POST", "create-form") };

                return new ObjectResult(results);
            }

            [HttpGet]
            [Route("{id}")]
            public async Task<IActionResult> Get(string id)
            {
                var query = new GetProductQuery(_context, _typeAdapterConfig);
                var post = await query.Execute(id);

                return post == null
                    ? new NotFoundResult() as ActionResult
                    : new ObjectResult(post);
            }

            public async Task<IActionResult> Post([FromBody] ProductCreateModel model)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new
                    {
                        code = 400,
                        message = ModelState.Values.First().Errors.First().ErrorMessage
                    });
                }

                var createQuery = new CreateProductQuery(_context, _typeAdapterConfig);
                var post = await createQuery.Execute(model);

                return new CreatedAtRouteResult("default", new { controller = Endpoint, id = post.Item1 }, post.Item2);
            }
        
    }
}