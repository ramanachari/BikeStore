using System.Collections.Generic;
using AutoMapper;
using BikeStoreWeb.Api.Data;
using BikeStoreWeb.Api.Models;
using BikeStoreWeb.Api.ViewDtos;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _commanderRepo;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo commanderRepo, IMapper mapper)
        {
            _commanderRepo = commanderRepo;
            _mapper = mapper;
        }


        // GET: api/Commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commands = _commanderRepo.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }

        // GET api/Commands/5
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var command = _commanderRepo.GetCommandById(id);
            if (command != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(command));
            }

            return NotFound();
        }

        // POST api/Commands
        [HttpPost]
        public ActionResult<CommandCreateDto> CreateCommand(CommandCreateDto command)
        {
            if (command == null)
                return BadRequest();

            var commandModel = _mapper.Map<Command>(command);
            _commanderRepo.CreateCommand(commandModel);

            var commadRead = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new { commandModel.Id }, commadRead);
        }

        // PUT api/Commands/5
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandCreateDto commandUpdate)
        {
            var commnad = _commanderRepo.GetCommandById(id);
            if (commnad == null)
                return NotFound();
            _mapper.Map(commandUpdate, commnad);

            _commanderRepo.UpdateCommand(commnad);

            return NoContent();
        }

        // DELETE api/Commands/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _commanderRepo.DeleteCommand(id);
            return NoContent();
        }
    }
}
