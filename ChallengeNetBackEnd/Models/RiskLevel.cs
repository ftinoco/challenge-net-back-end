using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("risklevel", Schema = "public")]
    public class RiskLevel: EntityBase
    {
        [Column("title")]
        public string Title { get; set; }
        [Column("code")]
        public string Code { get; set; }
    }
}
