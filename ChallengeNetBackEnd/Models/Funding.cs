using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("funding", Schema = "public")]
    public class Funding: EntityBase
    {
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("uuid")]
        public string Uuid { get; set; }
        [Column("mnemonic")]
        public string Mnemonic { get; set; }
        [Column("isbox")]
        public bool IsBox { get; set; }
        [Column("yahoomnemonic")]
        public string? YahooMnemonic { get; set; }
        [Column("cmfurl")]
        public string? CMFUrl { get; set; }
        [Column("currencyid")]
        public int? CurrencyId { get; set; }
        [Column("hassharevalue")]
        public bool HasShareValue { get; set; }

        [ForeignKey("financialentityid")]
        public virtual FinancialEntity FinancialEntity { get; set; }
        public virtual IEnumerable<FundingShareValue> FundingShareValue { get; set; }

    }
}