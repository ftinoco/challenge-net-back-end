using System.Text.Json;

namespace ChallengeNetBackEnd.Models.DTOs
{
    public class PortfolioDTO
    {
        public double MaxRangeYear { get; set; }
        public double MinRangeYear { get; set; }
        public string Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FinancialEntity { get; set; }
        public string RiskLevel { get; set; }
        public bool IsDefault { get; set; }
        public JsonDocument? Profitability { get; set; }
        public int? InvestmentStrategyId { get; set; }
        public string Version { get; set; }
        public string ExtraProfitabilityCurrencyCode { get; set; }
        public double EstimatedProfitability { get; set; }
        public double BPComission { get; set; }
    }
}
