using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRSTCRUD
{
    class EmployeeContext : DbContext
    {
        // Inherite DbContext Class
        public DbSet<Employee> Employee { get; set; }
        //public DbSet<ClassName> TableName { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Overriding method OnConfiguring --> Evey time calling the instance
            if (!optionsBuilder.IsConfigured)
            {
                //!optionsBuilder.IsConfigured == class[object].CallMethod
                // Checking optionBuilder
                // If present or it is not null then connection// BuDefault
                optionsBuilder.UseSqlServer(@"Server=NSL-LTRG007\SQLEXPRESS2019;Database=satish;Integrated Security=True;");
                //UseSqlServer
            }
        }


    }
}
