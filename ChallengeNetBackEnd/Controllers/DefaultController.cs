using ChallengeNetBackEnd.Data.Implementations;
using ChallengeNetBackEnd.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeNetBackEnd.Controllers
{ 
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly IDataContext _context;

        public DefaultController(IDataContext context)
        {
            _context = context;
        }

        [HttpGet("ping")]
        public string ping()
        {
            return "pong";
        }

        [HttpGet("canConnect")] 
        public string DbConnection()
        {
            if (((DataContext)_context).Database.CanConnect())
                return "connected!";
            return "without connection!";
        }
    }
}
