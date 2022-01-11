using System.ComponentModel.DataAnnotations;

namespace MVC_CORE_CRUD.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}
