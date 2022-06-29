using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myIMDb.Data.Services;
using myIMDb.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myIMDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        public ActorService _actorService;
        public  ActorController (ActorService actorService )
        {
            _actorService = actorService;
        }

        [HttpPost]
        public IActionResult AddActor([FromBody] ActorVM actor)
        {
            _actorService.AddActor(actor);
            return Ok();
        }

        [HttpGet("get-all-actors")]
        public IActionResult GetAllActors()
        {
            var allActors = _actorService.GetAllActors();
            return Ok(allActors);
        }

        [HttpDelete("delete-actor-by-id/{id}")]
        public IActionResult DeleteActorById(int id)
        {
            _actorService.DeleteActorById(id);
            return Ok();
        }
    }
}
