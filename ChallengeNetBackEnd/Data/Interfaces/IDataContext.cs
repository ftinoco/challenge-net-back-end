using ChallengeNetBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeNetBackEnd.Data.Interfaces
{
    public interface IDataContext
    {
        DbSet<User> User { get; set; }
    }
}
