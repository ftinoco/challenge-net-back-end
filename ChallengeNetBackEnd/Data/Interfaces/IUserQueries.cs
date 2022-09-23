using ChallengeNetBackEnd.Models;
using ChallengeNetBackEnd.Models.DTOs;

namespace ChallengeNetBackEnd.Data.Interfaces
{
    public interface IUserQueries
    {
        UserDTO? GetUserById(int id);
        SummaryDTO? GetSummary(int userId);
        SummaryDTO? GetSummary(int userId, DateTime date);
        IEnumerable<GoalDTO> GetGoals(int userId);
    }
}