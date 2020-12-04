using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetmicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VacuumRobotController : ControllerBase
    {
        private readonly ILogger<VacuumRobotController> _logger;

        public VacuumRobotController(ILogger<VacuumRobotController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public VacuumRobot Get()
        {
            var rng = new Random();

            return new VacuumRobot {
                position = new Coordinate {
                    x = rng.Next(-1000, 1000),
                    y = rng.Next(-1000, 1000)
                }
            };
        }
    }
}
