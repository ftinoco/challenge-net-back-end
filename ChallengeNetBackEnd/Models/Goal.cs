using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("goal", Schema = "public")]
    public class Goal: EntityBase
    {
        [Column("title")]
        public string Title { get; set; }
        [Column("years")]
        public int Years { get; set; }
        [Column("initialinvestment")]
        public int InitialInvestment { get; set; }
        [Column("monthlycontribution")]
        public int MonthlyContribution { get; set; }
        [Column("targetamount")]
        public int TargetAmount { get; set; }
        [Column("goalcategoryid")]
        public int GoalCategoryId { get; set; }
        [Column("risklevelid")]
        public int RiskLevelId { get; set; }
        [Column("currencyid")]
        public int CurrencyId { get; set; }
        [Column("displaycurrencyid")]
        public int DisplayCurrencyId { get; set; }

        [ForeignKey("userid")]
        public virtual User User { get; set; }
        [ForeignKey("portfolioid")]
        public virtual Portfolio Portfolio { get; set; }
        [ForeignKey("financialentityid")]
        public virtual FinancialEntity? FinancialEntity { get; set; }
    }
}
