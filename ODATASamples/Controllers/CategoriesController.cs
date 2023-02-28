using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using ODATASamples.Models;

namespace ODATASamples.Controllers
{
    public class CategoriesController : ODataController
    {
        private readonly ApplicationDbContext _context;
        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Categories);
        }
    }
}
