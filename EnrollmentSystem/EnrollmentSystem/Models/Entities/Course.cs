using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrollmentSystem.Models.Entities
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int course_id { get; set; }
        [Required(ErrorMessage = "Course Code is required.")]
        public string course_code {  get; set; } = "-";
        [Required(ErrorMessage = "Course Title is required.")]
        public string course_title { get; set; } = "-";
            [Required(ErrorMessage = "Course Description Code is required.")]
        public string course_desc { get; set; } = "-";
        [Required(ErrorMessage = "Department is required.")]
        public int? dept_id { get; set; }
    }
}
