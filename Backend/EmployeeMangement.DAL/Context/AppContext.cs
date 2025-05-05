using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMangement.DAL
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options): base(options) 
        { }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            
            var seeders = new List<ISeeder>
            {
                new EmployeeSeeder()
            };

            foreach (var seeder in seeders)
            {
                seeder.Seed(modelBuilder);
            }
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
        }
    }
}
