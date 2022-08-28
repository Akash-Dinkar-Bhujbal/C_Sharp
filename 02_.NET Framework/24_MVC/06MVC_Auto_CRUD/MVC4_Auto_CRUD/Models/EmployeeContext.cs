using Microsoft.EntityFrameworkCore;

namespace MVC4_Auto_CRUD.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=NSL-LTRG007\SQLEXPRESS2019;Database=test3;Integrated Security=True;");
            }
        }
    }
}
