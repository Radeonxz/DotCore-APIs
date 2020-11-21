using System.Collections.Generic;
using Commander.Data;
using commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    // api/commands
    // [Route("api/[controller]")]
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCoommanderRepo _repository = new MockCommanderRepo();
        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Commander>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        // GET api/commands/1
        [HttpGet("{id}")]
        public ActionResult <Commander> GetCommandById(int id)
        {
            var commandItems = _repository.GetCommandById(id);

            return Ok(commandItems);
        }
    }
}