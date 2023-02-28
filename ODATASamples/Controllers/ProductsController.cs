using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODATASamples.Models;

namespace ODATASamples.Controllers
{
    public class ProductsController : ODataController
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [EnableQuery(PageSize = 5)]
        [HttpGet]
        [ODataRoute("Products")]
        public IActionResult Get()
        {
            return Ok(_context.Products);
        }
    }
}
