using System.ComponentModel.DataAnnotations;

namespace EnrollmentSystem.Models.Dto
{
    public class LoginDto
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
