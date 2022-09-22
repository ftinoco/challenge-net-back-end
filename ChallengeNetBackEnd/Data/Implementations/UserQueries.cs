using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Models;

namespace ChallengeNetBackEnd.Data.Implementations
{
    public class UserQueries : IUserQueries
    {
        private readonly IDataContext _context;

        public UserQueries(IDataContext context)
        {
            _context = context;
        }

        public User? GetUserById(int id)
        {
           return _context.User.Find(id);
        }
    }
}
