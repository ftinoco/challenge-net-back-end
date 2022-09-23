using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("goaltransactionfunding", Schema = "public")]
    public class GoalTransactionFunding: EntityBase
    {
        [Column("percentage")]
        public double Percentage { get; set; }
        [Column("amount")]
        public double Amount { get; set; }
        [Column("quotas")]
        public double Quotas { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("cost")]
        public double Cost { get; set; }

        [ForeignKey("goalid")]
        public virtual Goal Goal { get; set; }
        [ForeignKey("ownerid")]
        public virtual User Owner { get; set; }
        [ForeignKey("fundingid")]
        public virtual Funding Funding { get; set; }
        [ForeignKey("transactionid")]
        public virtual GoalTansaction GoalTansaction { get; set; }
    }
}