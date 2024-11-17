using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrollmentSystem.Models.Entities
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int room_id { get; set; }
        [Required(ErrorMessage = "Room Code is required.")]
        public string room_code { get; set; } = "-";
        [Required(ErrorMessage = "Room Type is required.")]
        public string room_type { get; set; } = "-";
    }
}
