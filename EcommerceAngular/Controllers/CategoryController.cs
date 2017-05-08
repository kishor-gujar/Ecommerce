using System.Linq;
using EcommerceAngular.Models;
using EcommerceData.Data;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using EcommerceAngular.Queries;

namespace EcommerceAngular.Controllers
{
    [Route(Endpoint)]
    public class CategoryController : Controller
    {
        public const string Endpoint = "api/categories";

        private readonly ApplicationDbContext _context;
        private readonly PagedCollectionParameters _defaultPagingOptions;
        private readonly TypeAdapterConfig _typeAdapterConfig;

        public CategoryController(
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
            var getAllQuery = new GetAllCategoriesQuery(_context, _defaultPagingOptions, _typeAdapterConfig, Endpoint);
            var results = await getAllQuery.Execute(parameters);

            // Attach form definitions for discoverability
            results.Forms = new[] { Form.FromModel<CategoryCreateModel>(Endpoint, "POST", "create-form") };

            return new ObjectResult(results);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var query = new GetCategoryQuery(_context, _typeAdapterConfig);
            var post = await query.Execute(id);

            return post == null
                ? new NotFoundResult() as ActionResult
                : new ObjectResult(post);
        }

        public async Task<IActionResult> Post([FromBody] CategoryCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    code = 400,
                    message = ModelState.Values.First().Errors.First().ErrorMessage
                });
            }

            var createQuery = new CreateCategoryQuery(_context, _typeAdapterConfig);
            var post = await createQuery.Execute(model);

            return new CreatedAtRouteResult("default", new { controller = Endpoint, id = post.Item1 }, post.Item2);
        }
    }
}