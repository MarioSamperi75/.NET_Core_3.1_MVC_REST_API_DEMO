using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllComands()
        {
            var commandItems = _repository.GetAppCommand();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetComandById(int id)
        {
            var item = _repository.GetCommandById(id);
            return Ok(item);
        }


    }
}
