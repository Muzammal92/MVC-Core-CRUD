using Microsoft.EntityFrameworkCore;

namespace MVC_CORE_CRUD.Models
{
    public class CRUDContext:DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options):base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
