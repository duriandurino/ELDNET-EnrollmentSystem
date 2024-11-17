using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrollmentSystem.Models.Entities
{
    public class Semester
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sem_id { get; set; }
        [Required(ErrorMessage = "Semester Year is required.")]
        public string sem_year { get; set; } = "-";
        [Required(ErrorMessage = "Semester Start is required.")]
        public DateTime sem_start { get; set; }
        [Required(ErrorMessage = "Semester End is required.")]
        public DateTime sem_end { get; set; }
    }
}
