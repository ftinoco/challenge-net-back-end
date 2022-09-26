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
                                Contributions = goal.GoalTransactions.Where(x => x.Type == "buy").Sum(y => y.Amount),
                                Withdrawal = goal.GoalTransactions.Where(x => x.Type == "sale").Sum(y => y.Amount),
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

        public SummaryDTO? GetSummary(int userId)
        {
            return GetSummary(userId, DateTime.Now);
        }

        public SummaryDTO? GetSummary(int userId, DateTime date)
        {
            // Se optó por hacer el query con linq para mantener el código
            // sin sentencias sql embebidas y se evitó lambda para tratar
            // de hacerlo mas entendible
            var summary = from u in _context.User
                          where u.Id == userId
                          join gtf in _context.GoalTransactionFunding on
                                u.Id equals gtf.Owner.Id
                          join gt in _context.GoalTansaction on
                                gtf.GoalTansaction.Id equals gt.Id
                          join f in _context.Funding on
                                gtf.Funding.Id equals f.Id
                          join fsv in _context.FundingShareValue on
                                f.Id equals fsv.Funding.Id
                          join ci in _context.CurrencyIndicator on
                                new { dest = u.CurrencyId, src = gt.CurrencyId, Date = date } equals
                                new { dest = ci.DestinationCurrencyId, src = ci.SourceCurrencyId, ci.Date } into leftj
                          from temp in leftj.DefaultIfEmpty()
                          // TODO: En este punto se entendió que era hasta la fecha proporcionada
                          where fsv.Date <= date  
                          select new
                          { 
                              UserId = u.Id,
                              Balance = gtf.Quotas * fsv.Value * (temp == null ? 0 : temp.Value),
                              Contributions = gt.Amount * (temp == null ? 0 : temp.Value)
                          };

            return summary.GroupBy(x => x.UserId)
                .Select(x => new SummaryDTO
                {
                    Balance = x.Sum(x => x.Balance),
                    Contributions = x.Sum(x => x.Contributions)
                }).FirstOrDefault(); 
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
