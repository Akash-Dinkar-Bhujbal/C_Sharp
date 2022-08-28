using System.ComponentModel.DataAnnotations;

namespace MVC_Validation.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Please enter address")]
        [StringLength(10)]
        public string Address { get; set; }
    }
}
