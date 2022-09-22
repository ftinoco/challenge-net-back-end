using ChallengeNetBackEnd.Models;

namespace ChallengeNetBackEnd.Data.Interfaces
{
    public interface IUserQueries
    {
        User? GetUserById(int id);
    }
}
