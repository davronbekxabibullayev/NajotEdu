using System.ComponentModel.DataAnnotations;

namespace NajotEdu.Application.Models
{
    public class CreateTeacherModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
