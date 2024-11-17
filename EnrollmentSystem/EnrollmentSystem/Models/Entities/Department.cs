using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrollmentSystem.Models.Entities
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int dept_id { get; set; }
        [Required(ErrorMessage = "Department Code is required.")]
        public string dept_code { get; set; } = "-";
        [Required(ErrorMessage = "Department Name is required.")]
        public string dept_name { get; set; } = "-";
    }
}
