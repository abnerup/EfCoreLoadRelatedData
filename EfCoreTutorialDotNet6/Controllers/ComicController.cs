using Microsoft.AspNetCore.Mvc;

namespace EfCoreTutorialDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {
        private readonly DataContext context;

        public ComicController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Comic>>> Get()
        { 
            var comics = await context.Comics.ToListAsync();
            return Ok(comics);
        }
    }
}
