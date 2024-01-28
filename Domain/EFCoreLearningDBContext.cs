using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class EFCoreLearningDBContext : DbContext
    {


        public EFCoreLearningDBContext(DbContextOptions<EFCoreLearningDBContext> options) : base(options)
        {
                
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFCoreLearningDBContext).Assembly);
        }


        public DbSet<Employee> Employees { get; set;}

        public DbSet<Department> Departments { get; set;}   
    }
}
