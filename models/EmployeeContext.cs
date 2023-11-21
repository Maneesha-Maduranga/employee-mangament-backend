using Microsoft.EntityFrameworkCore;
namespace employee_mangment_backend.models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
           : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = null!;
    }
}
