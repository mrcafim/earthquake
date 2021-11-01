using Earthquake.API.DTO;
using Earthquake.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earthquake.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EarthquakeController : ControllerBase
    {
        private readonly IEarthquakeService _earthquakeService;
        public EarthquakeController(IEarthquakeService earthquakeService)
        {
            _earthquakeService = earthquakeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] EarthquakeQuery query)
        {
            if ((query.Lat == 0 && query.Long != 0) || (query.Long == 0 && query.Lat != 0)) return BadRequest("Coordinates are not valid. ");
            
            var response = await _earthquakeService.GetQuakes(query);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
