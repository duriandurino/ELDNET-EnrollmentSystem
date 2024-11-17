using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrollmentSystem.Models.Entities
{
    public class Enroll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enroll_id { get; set; }
        public int? stud_id { get; set; }
        public DateTime enroll_date { get; set; }
        public int? sem_id { get; set; }
        public int? class_id { get; set; }
        public int? user_id {  get; set; }
    }
}
