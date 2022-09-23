using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace ChallengeNetBackEnd.Models
{
    [Table("portfolio", Schema = "public")]
    public class Portfolio: EntityBase
    {
        [Column("maxrangeyear")]
        public double MaxRangeYear { get; set; }
        [Column("minrangeyear")]
        public double MinRangeYear { get; set; }
        [Column("uuid")]
        public string Uuid { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("risklevelid")]
        public int RiskLevelId { get; set; }
        [Column("isdefault")]
        public bool IsDefault { get; set; }
        [Column("profitability")]
        public JsonDocument? Profitability{ get; set; }
        [Column("investmentstrategyid")]
        public int? InvestmentStrategyId { get; set; }
        [Column("version")]
        public string Version { get; set; }
        [Column("extraprofitabilitycurrencycode")]
        public string ExtraProfitabilityCurrencyCode { get; set; }
        [Column("estimatedprofitability")]
        public double EstimatedProfitability { get; set; }
        [Column("bpcomission")]
        public double BPComission { get; set; }


    }
}
