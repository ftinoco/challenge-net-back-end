namespace ChallengeNetBackEnd.Models.DTOs
{
    public class GoalDetailDTO: GoalDTO
    {
        public string GoalCategory { get; set; }
        public double Contributions { get; set; }
        public double Withdrawal { get; set; }
        public double TargetAmountPercentage { get; set; }
    }
}