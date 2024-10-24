using Katafish.Db;
using Katafish.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Threading.Tasks;

namespace Katafish.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController
    {

        private readonly KatafishDbContext _context;

        public TestController(KatafishDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Chef[] getAllChef(){
            return _context.Chefs.ToArray();
        }

        [HttpPost]
        public async Task<IActionResult> addChef([FromBody] Chef chef){
            await _context.Chefs.AddAsync(chef);
            await _context.SaveChangesAsync();
            return new CreatedResult($"/api/test/{chef.Id}", chef);
        }
    }
}