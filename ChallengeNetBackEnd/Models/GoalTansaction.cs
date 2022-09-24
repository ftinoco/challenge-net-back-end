using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("goaltransaction", Schema = "public")]
<<<<<<< HEAD
    public class GoalTansaction: EntityBase
=======
    public class GoalTansaction : EntityBase
>>>>>>> feat/get-goal-detail
    {
        [Column("type")]
        public string Type { get; set; }
        [Column("amount")]
        public double Amount { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("isprocessed")]
        public bool IsProcessed { get; set; }
        [Column("all")]
        public bool All { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("currencyid")]
        public int CurrencyId { get; set; }
        [Column("cost")]
        public double Cost { get; set; }

        [ForeignKey("goalid")]
        public virtual Goal? Goal { get; set; }
        [ForeignKey("ownerid")]
        public virtual User Owner { get; set; }
        [ForeignKey("financialentityid")]
        public virtual FinancialEntity? FinancialEntity { get; set; }
    }
}