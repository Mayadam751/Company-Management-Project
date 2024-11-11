using CompanyManagement.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMApplicationDbContext.DAL
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CompanyCustomers> CompanyCustomers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
               .HasKey(c => c.CompanyId);

            modelBuilder.Entity<Department>()
                .HasKey(d => d.DepartmentId);

            modelBuilder.Entity<Customer>()
                .HasKey(cu => cu.CustomerId);

            modelBuilder.Entity<Employee>()
                .HasKey(e => e.EmployeeId);

            modelBuilder.Entity<CompanyCustomers>()
                .HasKey(cc => new { cc.CustomerId, cc.CompanyId });

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.EmployeeDepartmentId);
        }
    }
}
