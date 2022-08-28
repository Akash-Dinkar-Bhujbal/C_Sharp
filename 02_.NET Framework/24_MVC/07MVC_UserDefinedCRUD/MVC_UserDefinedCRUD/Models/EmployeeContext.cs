using Microsoft.EntityFrameworkCore;

namespace MVC3_ORM.Models
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
