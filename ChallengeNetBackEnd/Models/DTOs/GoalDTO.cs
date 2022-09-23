namespace ChallengeNetBackEnd.Models.DTOs
{
    public class GoalDTO
    {
        public string Title { get; set; }
        public int Years { get; set; }
        public int InitialInvestment { get; set; }
        public int MonthlyContribution { get; set; }
        public int TargetAmount { get; set; }
        public string FinancialEntity { get; set; }
        public PortfolioDTO Portfolio { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
