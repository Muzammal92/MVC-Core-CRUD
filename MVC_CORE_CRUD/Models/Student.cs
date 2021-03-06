using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_CORE_CRUD.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Department")]
        public int DeptID { get; set; }

        [Required(ErrorMessage = "Required")]
        public string? Moblile { get; set; }
        public string? Description { get; set; }
        [NotMapped]
        public string? Department { get; set; }
    }
}
