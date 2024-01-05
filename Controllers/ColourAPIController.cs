using Dockersql.Models;
using Microsoft.AspNetCore.Mvc;

namespace DockerSQL.Models
{
[ApiController]
[Route("[Controller]")]
    public class ColourAPIController: ControllerBase
    {
        private readonly ColourContext _context;

        public ColourAPIController(ColourContext context)
        {
 _context =context;
        }
[HttpGet]
        public ActionResult<IEnumerable<Colour>> GetColourItems()
        {
            return _context.ColourItems;
        }

// [HttpGet]
//         public ActionResult<IEnumerable<String>> Get()
//         {
// return new string[] {"value1", "values2"};
//         }
    }
}