using System.ComponentModel.DataAnnotations;

namespace SportManagementSystem.Data.DTO
{
    public class TeamDTO
    {
        [Required]
        public string Name { get; set; }

        public string Captain { get; set; }

        public string Coach { get; set; }

        public string Logo { get; set; }

        [Required]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Phone]
        public string ContactPhone { get; set; }

        public int TotalWins { get; set; }

        public int TotalLosses { get; set; }

        public int TotalDraws { get; set; }
    }
}
