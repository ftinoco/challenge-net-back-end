using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("fundingsharevalue", Schema = "public")]
    public class FundingShareValue: EntityBase
    {
        [Column("value")]
        public double Value { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [ForeignKey("fundingid")]
        public virtual Funding Funding { get; set; }
    }
}