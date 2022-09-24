using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    [Table("goalcategory", Schema = "public")]
    public class GoalCategory : EntityBase
    {
        [Column("code")]
        public string Code { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("uuid")]
        public string Uuid { get; set; }
    }
}
