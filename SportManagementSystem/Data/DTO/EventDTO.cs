using SportManagementSystem.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace SportManagementSystem.Data.DTO
{
    public class EventDTO
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public EventStatus Status { get; set; }
    }
}
