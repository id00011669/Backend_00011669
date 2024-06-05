using Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace Backend.DBConfig
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Employee> Employee{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=employee.cn66u064yw3o.eu-north-1.rds.amazonaws.com;Port=5432;Database=postgres;Username=postgres;Password=00011669");
    }
}

