using System.Collections.Generic;
using Commander.Data;
using commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    private readonly ICommanderRepo _repository;

    public CommandsController(ICommanderRepo repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    // api/commands
    // [Route("api/[controller]")]
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var commandItems = _repository.GetCommandById(id);
            if(commandItems != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(commandItems));
            }

            return NotFound();
        }
    }
}