using SportManagementSystem.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace SportManagementSystem.Data.DTO
{
    public class PlayerDTO
    {
        public int ID { get; set; }

        [Required]
        public int TeamID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        [Range(18, 99)]
        public int Age { get; set; }

        public int JerseyNumber { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        [Required]
        public string Nationality { get; set; }
    }

}
