using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("user", Schema = "public")]
    public class User : EntityBase
    {
        [Column("firstname")]
        public string FirstName { get; set; }
        [Column("surname")]
        public string Surname { get; set; }
        [Column("currencyid")]
        public int CurrencyId { get; set; }

        [ForeignKey("advisorid")]
        public virtual User? Advisor { get; set; } 
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<GoalTansaction> GoalTansactions { get; set; }
        public virtual ICollection<GoalTransactionFunding> GoalTransactionsFunding { get; set; }
    }
}
