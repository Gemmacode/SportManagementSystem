using SportManagementSystem.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace SportManagementSystem.Data.DTO
{
    public class MatchDTO
    {
        public int ID { get; set; }

        [Required]
        public int EventID { get; set; }

        [Required]
        public int HomeTeamID { get; set; }

        [Required]
        public int AwayTeamID { get; set; }

        [Required]
        public DateTime MatchDate { get; set; }

        [Required]
        public string Venue { get; set; }

        public string Referee { get; set; }

        [Required]
        public MatchStatus Status { get; set; }

        public int HomeTeamScore { get; set; }

        public int AwayTeamScore { get; set; }
    }
}
