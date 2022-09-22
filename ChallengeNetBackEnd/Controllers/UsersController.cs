using AutoMapper;
using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeNetBackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IMapper _mapper;
        private readonly IUserQueries _queries;

        public UsersController(
            IUserQueries queries,
            IMapper mapper)
        {
            _queries = queries;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public UserDTO GetUserById(int id)
        {
            var user = _queries.GetUserById(id);
            return _mapper.Map<UserDTO>(user);
        }
    }
}
