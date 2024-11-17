using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        [Required]
        public string username { get; set; } = "-";
        [Required]
        public string password { get; set; } = "-";

        [Required(ErrorMessage = "can_view is required.")]
        public int can_view { get; set; } = 0;
        [Required(ErrorMessage = "can_edit is required.")]
        public int can_edit { get; set; } = 0;
        [Required(ErrorMessage = "can_delete is required.")]
        public int can_delete { get; set; } = 0;
        [Required(ErrorMessage = "can_add is required.")]
        public int can_add { get; set; } = 0;
    }
}
