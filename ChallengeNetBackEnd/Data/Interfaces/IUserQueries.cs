using ChallengeNetBackEnd.Models;
using ChallengeNetBackEnd.Models.DTOs;

namespace ChallengeNetBackEnd.Data.Interfaces
{
    public interface IUserQueries
    {
        UserDTO? GetUserById(int id);
        IEnumerable<GoalDTO> GetGoals(int userId);
        GoalDetailDTO? GetGoalDetail(int userId, int goalId);
    }
}
