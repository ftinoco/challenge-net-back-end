using ChallengeNetBackEnd.Data.Interfaces;
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

        public GoalDetailDTO? GetGoalDetail(int userId, int goalId)
        {
            return _context.Goal.Where(x => x.User.Id == userId && x.Id == goalId)
                            .Select(goal => new GoalDetailDTO()
                            {
                                CreationDate = goal.Created,
                                FinancialEntity = goal.FinancialEntity == null ? string.Empty : goal.FinancialEntity.Title,
                                InitialInvestment = goal.InitialInvestment,
                                MonthlyContribution = goal.MonthlyContribution,
                                TargetAmount = goal.TargetAmount,
                                Title = goal.Title,
                                Years = goal.Years,
                                GoalCategory = goal.GoalCategory.Title,
                                TargetAmountPercentage = ((goal.GoalTransactions.Sum(y => y.Amount)) * 100) / goal.TargetAmount,
                                Contributions = goal.GoalTransactions.Sum(y => y.Amount),
                                Withdrawal = 0,
                                Portfolio = new PortfolioDTO()
                                {
                                    Title = goal.Portfolio.Title,
                                    BPComission = goal.Portfolio.BPComission,
                                    Description = goal.Portfolio.Description,
                                    EstimatedProfitability = goal.Portfolio.EstimatedProfitability,
                                    ExtraProfitabilityCurrencyCode = goal.Portfolio.ExtraProfitabilityCurrencyCode ?? string.Empty,
                                    InvestmentStrategyId = goal.Portfolio.InvestmentStrategyId,
                                    IsDefault = goal.Portfolio.IsDefault,
                                    MaxRangeYear = goal.Portfolio.MaxRangeYear,
                                    MinRangeYear = goal.Portfolio.MinRangeYear,
                                    Profitability = goal.Portfolio.Profitability,
                                    FinancialEntity = goal.Portfolio.FinancialEntity.Title,
                                    RiskLevel = goal.Portfolio.RiskLevel.Title,
                                    Uuid = goal.Portfolio.Uuid,
                                    Version = goal.Portfolio.Version
                                }
                            }).FirstOrDefault();
        }

        public IEnumerable<GoalDTO> GetGoals(int userId)
        {
            return _context.User.Where(x => x.Id == userId)
                            .SelectMany(y => y.Goals,
                            (user, goal) => new GoalDTO()
                            {
                                CreationDate = goal.Created,
                                FinancialEntity = goal.FinancialEntity == null ? string.Empty : goal.FinancialEntity.Title,
                                InitialInvestment = goal.InitialInvestment,
                                MonthlyContribution = goal.MonthlyContribution,
                                TargetAmount = goal.TargetAmount,
                                Title = goal.Title,
                                Years = goal.Years,
                                Portfolio = new PortfolioDTO()
                                {
                                    Title = goal.Portfolio.Title,
                                    BPComission = goal.Portfolio.BPComission,
                                    Description = goal.Portfolio.Description,
                                    EstimatedProfitability = goal.Portfolio.EstimatedProfitability,
                                    ExtraProfitabilityCurrencyCode = goal.Portfolio.ExtraProfitabilityCurrencyCode ?? string.Empty,
                                    InvestmentStrategyId = goal.Portfolio.InvestmentStrategyId,
                                    IsDefault = goal.Portfolio.IsDefault,
                                    MaxRangeYear = goal.Portfolio.MaxRangeYear,
                                    MinRangeYear = goal.Portfolio.MinRangeYear,
                                    Profitability = goal.Portfolio.Profitability,
                                    FinancialEntity = goal.Portfolio.FinancialEntity.Title,
                                    RiskLevel = goal.Portfolio.RiskLevel.Title,
                                    Uuid = goal.Portfolio.Uuid,
                                    Version = goal.Portfolio.Version
                                }
                            }).ToList();
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
