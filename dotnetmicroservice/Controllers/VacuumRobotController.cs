using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace dotnetmicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VacuumRobotController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger<VacuumRobotController> _logger;

        public VacuumRobotController(ILogger<VacuumRobotController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public VacuumRobot Get()
        {
            using (var db = new ApiDbContext(_configuration)) 
            {
                var robot = db.Robots.OrderBy(r => r.Id).First();

                return new VacuumRobot
                {
                    position = new Coordinate
                    {
                        x = robot.positionX,
                        y = robot.positionY
                    }
                };
            }
        }
    }
}
