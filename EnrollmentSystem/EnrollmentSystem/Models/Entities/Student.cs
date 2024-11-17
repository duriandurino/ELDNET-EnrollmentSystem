using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnrollmentSystem.Models.Entities
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int stud_id { get; set; }
        public string stud_fname { get; set; } = "-";
        public string stud_lname { get; set; } = "-";
        public string? stud_mname { get; set; }
        public string stud_email { get; set; } = "-";
        public string stud_address {  get; set; } = "-";
        public string? stud_phone { get; set; }
        public string stud_section { get; set; } = "-";

    }
}
