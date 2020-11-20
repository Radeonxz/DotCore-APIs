using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // api/commands
    // [Route("api/[controller]")]
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult <IEnumerable<Commander>> GetAllCommands()
        {

        }

        // GET api/commands/1
        [HttpGet("{id}")]
        public ActionResult <Commander> GetCommandById(int id)
        {

        }
    }
}