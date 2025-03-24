using KazanNeft.Models;
using Microsoft.EntityFrameworkCore;

namespace KazanNeft.Database
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=localhost;port=3306;Database=session2;uid=root;password=root";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetsGroup> AssetsGroups { get; set; }
        public DbSet<ChangedPart> ChangedParts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentLocation> DepartmentLocations { get; set; }
        public DbSet<EmergencyMaintenance> EmergencyMaintenances { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
