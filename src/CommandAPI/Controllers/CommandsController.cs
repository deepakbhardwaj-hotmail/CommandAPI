using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CommandsController:ControllerBase
    {
        public readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository=repository;
        }

        /*
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() 
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
        */
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

    }
}