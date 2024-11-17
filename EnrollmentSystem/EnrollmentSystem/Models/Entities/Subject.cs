using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Entities
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int subj_id { get; set; }
        [Required(ErrorMessage = "Subject Code is required.")]
        public string subj_code { get; set; } = "-";
        [Required(ErrorMessage = "Start Name is required.")]
        public string subj_desc { get; set; } = "-";
        public int? course_id { get; set; }
    }
}
