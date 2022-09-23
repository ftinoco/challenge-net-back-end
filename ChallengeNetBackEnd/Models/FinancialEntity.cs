using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("financialentity", Schema = "public")]
    public class FinancialEntity: EntityBase
    {
        [Column("logo")]
        public string Logo { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("uuid")]
        public string Uuid { get; set; }
        [Column("description")]
        public string Description { get; set; }
        
    }
}
