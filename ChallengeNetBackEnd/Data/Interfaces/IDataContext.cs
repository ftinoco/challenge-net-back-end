using ChallengeNetBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeNetBackEnd.Data.Interfaces
{
    public interface IDataContext
    {
        DbSet<User> User { get; set; }
        DbSet<Portfolio> Portfolio { get; set; }
        DbSet<Goal> Goal { get; set; }
        DbSet<CurrencyIndicator> CurrencyIndicator { get; set; }
        DbSet<FinancialEntity> FinancialEntity { get; set; }
        DbSet<Funding> Funding { get; set; }
        DbSet<FundingShareValue> FundingShareValue { get; set; }
        DbSet<GoalTansaction> GoalTansaction { get; set; }
        DbSet<GoalTransactionFunding> GoalTransactionFunding { get; set; }
        DbSet<RiskLevel> RiskLevel { get; set; }
    }
}