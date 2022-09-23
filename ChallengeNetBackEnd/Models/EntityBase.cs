using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeNetBackEnd.Models
{
    public abstract class EntityBase
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("created")]
        public DateTime Created { get; set; }
        [Column("modified")]
        public DateTime Modified { get; set; }
    }
}
