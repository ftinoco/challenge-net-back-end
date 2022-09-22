using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("user", Schema = "public")]
    public class User
    {

        [Column("id")]
        public int Id { get; set; }
        [Column("firstname")]
        public string FirstName { get; set; }
        [Column("surname")]
        public string Surname { get; set; }
        [Column("created")]
        public DateTime Created { get; set; }
        [Column("modified")]
        public DateTime Modified { get; set; }
        [Column("currencyid")]
        public int CurrencyId { get; set; }

        [ForeignKey("advisorid")]
        public virtual User? Advisor { get; set; }
    }
}
