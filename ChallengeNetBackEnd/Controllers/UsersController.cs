using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeNetBackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserQueries _queries;

        public UsersController(IUserQueries queries)
        {
            _queries = queries;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(404, Type = typeof(string))]
        [ProducesResponseType(200, Type = typeof(UserDTO))]
        public IActionResult GetUserById(int id)
        {
            var dto = _queries.GetUserById(id);
            if (dto == null)
                return NotFound("User not found!");
            return Ok(dto);
        }

        [HttpGet("{id}/goals")]
        [ProducesResponseType(404, Type = typeof(string))]
        [ProducesResponseType(200, Type = typeof(IEnumerable<GoalDTO>))]
        public IActionResult GetGoalsByUserId(int id)
        {
            var dto = _queries.GetGoals(id); 
            if (dto == null)
                return NotFound("User not found!");
            return Ok(dto);
        }
    }
}
