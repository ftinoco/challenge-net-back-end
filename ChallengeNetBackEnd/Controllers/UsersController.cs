using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Models.DTOs;
using ChallengeNetBackEnd.Utils;
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

        /// <summary>
        /// Obtiene el resumen del usuario.
        /// OJO: Probablemente el resultado sea 0 en balance y aportes
        /// hasta que no se actualice la tabla de CurrencyIndicator
        /// con la tasas de conversion a la fecha actual
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}/summary")]
        [ProducesResponseType(404, Type = typeof(string))]
        [ProducesResponseType(200, Type = typeof(SummaryDTO))]
        public IActionResult GetSummaryByUserId(int id)
        {
            var dto = _queries.GetSummary(id);
            if (dto == null)
                return NotFound("No information to show!");
            return Ok(dto);
        }

        [HttpGet("{id}/summary/{date}")]
        [ProducesResponseType(400, Type = typeof(string))]
        [ProducesResponseType(404, Type = typeof(string))]
        [ProducesResponseType(200, Type = typeof(SummaryDTO))]
        public IActionResult GetSummaryByUserId(int id, string date)
        {
            string msg = Helpers.ParsingStringToDate(date, out DateTime paramDate);
            if (msg == string.Empty)
            {
                var dto = _queries.GetSummary(id, paramDate);
                if (dto == null)
                    return NotFound("No information to show!");
                return Ok(dto);
            }
            return BadRequest(msg);
        }

        [HttpGet("{id}/goals")]
        [ProducesResponseType(404, Type = typeof(string))]
        [ProducesResponseType(200, Type = typeof(IEnumerable<GoalDTO>))]
        public IActionResult GetGoalsByUserId(int id)
        {
            var dto = _queries.GetGoals(id);
            if (dto == null)
                return NotFound("No information to show!");
            return Ok(dto);
        }

        [HttpGet("{id}/goals/{goalId}")]
        [ProducesResponseType(404, Type = typeof(string))]
        [ProducesResponseType(200, Type = typeof(GoalDetailDTO))]
        public IActionResult GetGoalDetail(int id, int goalId)
        {
            var dto = _queries.GetGoalDetail(id,  goalId);
            if (dto == null)
                return NotFound("No information to show!");
            return Ok(dto);
        }
    }
}
