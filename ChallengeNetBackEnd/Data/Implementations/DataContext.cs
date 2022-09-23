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
        public DbSet<CurrencyIndicator> CurrencyIndicator { get; set; }
        public DbSet<FinancialEntity> FinancialEntity { get; set; }
        public DbSet<Funding> Funding { get; set; }
        public DbSet<FundingShareValue> FundingShareValue { get; set; }
        public DbSet<GoalTansaction> GoalTansaction { get; set; }
        public DbSet<GoalTransactionFunding> GoalTransactionFunding { get; set; }
        public DbSet<RiskLevel> RiskLevel { get; set; }
    }
}