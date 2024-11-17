using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Entities
{
    public class Class
    {
        public string class_id { get; set; }
        [Required(ErrorMessage = "EDP Code is required.")]
        public string class_code { get; set; }
        [Required(ErrorMessage = "Start Time is required.")]
        public DateTime class_starttime { get; set; }
        [Required(ErrorMessage = "End Time is required.")]
        public DateTime class_endtime { get; set; }
        [Required(ErrorMessage = "Day/s is/are required.")]
        public string class_days { get; set; } = "-";
        [Required(ErrorMessage = "Course is/are required.")]

        public int? subj_id { get; set; }
    }
}
