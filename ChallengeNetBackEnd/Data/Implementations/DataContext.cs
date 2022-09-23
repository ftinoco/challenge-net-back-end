using ChallengeNetBackEnd.Data.Interfaces;
using ChallengeNetBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeNetBackEnd.Data.Implementations
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions options)
            : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Goal> Goal { get; set; }
    }
}
