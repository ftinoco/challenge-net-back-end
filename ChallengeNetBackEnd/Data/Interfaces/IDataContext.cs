using ChallengeNetBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeNetBackEnd.Data.Interfaces
{
    public interface IDataContext
    {
        DbSet<User> User { get; set; }
        DbSet<Portfolio> Portfolio { get; set; }
        DbSet<Goal> Goal { get; set; }
    }
}
