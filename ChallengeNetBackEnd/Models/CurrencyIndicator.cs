using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("currencyindicator", Schema = "public")]
    public class CurrencyIndicator: EntityBase
    {
        [Column("sourcecurrencyid")]
        public int SourceCurrencyId { get; set; }
        [Column("destinationcurrencyid")]
        public int DestinationCurrencyId { get; set; }
        [Column("value")]
        public double Value { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("requestdate")]
        public DateTime RequestDate { get; set; }
        [Column("ask")]
        public double Ask { get; set; }
        [Column("bid")]
        public double Bid { get; set; }
    }
}