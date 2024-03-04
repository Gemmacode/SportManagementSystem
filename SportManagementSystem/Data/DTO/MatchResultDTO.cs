using System.ComponentModel.DataAnnotations;

namespace SportManagementSystem.Data.DTO
{
    public class MatchResultDTO
    {
        [Required]
        public int MatchID { get; set; }

        [Required]
        public int WinningTeamID { get; set; }

        [Required]
        public int LosingTeamID { get; set; }

        public bool Draw { get; set; }
    }
}
