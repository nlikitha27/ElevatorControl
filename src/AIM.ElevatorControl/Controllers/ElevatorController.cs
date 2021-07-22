using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AIM.ElevatorControl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        private readonly ILogger<ElevatorController> _logger;
        private readonly IElevator _elevator;

        public ElevatorController(ILogger<ElevatorController> logger, IElevator elevator)
        {
            _logger = logger;
            _elevator = elevator;
        }

        /// <summary>
        /// Get all floor requests.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<int> All()
        {
            return _elevator.All();
        }

        /// <summary>
        /// Assign Floor Request
        /// </summary>
        /// <param name="floor">Floor Number</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(int floor)
        {
            try
            {
                _elevator.FloorRequest(floor, null);
            }
            catch (IndexOutOfRangeException)
            {
                return BadRequest("Wrong floor");
            }

            return Ok();
        }

        /// <summary>
        /// Set next floor request.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Next()
        {
            return Ok(_elevator.Next());
        }
    }
}

