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
    public class ProducerController : ControllerBase
    {
        public ProducerService _producerService;
        public ProducerController(ProducerService producerService)
        {
            _producerService = producerService;
        }

        [HttpPost]
        public IActionResult AddProducer([FromBody] ProducerVM producer)
        {
            _producerService.AddProducer(producer);
            return Ok();
        }
        [HttpGet("get-all-producers")]
        public IActionResult GetAllProducers()
        {
            var allProd = _producerService.GetAllProducers();
            return Ok(allProd);
        }
        [HttpDelete("delete-producer-by-id/{id}")]
        public IActionResult DeleteProducerById(int id)
        {
            _producerService.DeleteProducerById(id);
            return Ok();
        }
    }
}
