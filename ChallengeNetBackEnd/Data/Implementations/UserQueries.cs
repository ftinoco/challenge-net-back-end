using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Models;
using ChallengeNetBackEnd.Models.DTOs;

namespace ChallengeNetBackEnd.Data.Implementations
{
    public class UserQueries : IUserQueries
    {
        private readonly IDataContext _context;

        public UserQueries(IDataContext context)
        {
            _context = context;
        }

        public UserDTO? GetUserById(int id)
        {
            return _context.User.Where(x => x.Id == id)
                       .Select(u => new UserDTO()
                       {
                           Id = u.Id,
                           Fullname = $"{u.FirstName} {u.Surname}",
                           AdvisorFullname = u.Advisor == null ? string.Empty :
                                            $"{u.Advisor.FirstName} {u.Advisor.Surname}",
                           CreationDate = u.Created
                       }).FirstOrDefault();
        }
    }
}
