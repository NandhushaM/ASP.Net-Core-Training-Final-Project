using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Core_Final_Project_Web_API.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillMap>().HasKey(sc => new { sc.EmployeeId, sc.SkillId });

            modelBuilder.Entity<SkillMap>()
                .HasOne<Employees>(sc => sc.Employees)
                .WithMany(s => s.SkillMaps)
                .HasForeignKey(sc => sc.EmployeeId);


            modelBuilder.Entity<SkillMap>()
                .HasOne<Skills>(sc => sc.Skills)
                .WithMany(s => s.SkillMaps)
                .HasForeignKey(sc => sc.SkillId);

            //Employees has one to many relationship with SoftLock
            modelBuilder.Entity<SoftLock>()
               .HasOne(bc => bc.Employees)
               .WithMany(b => b.SoftLocks)
               .HasForeignKey(bc => bc.EmployeeId);

            modelBuilder.Entity<Employees>().HasData(
new Employees
{
    EmployeeID = 1,
    Email = "nandhu@gmail.com",
    Experience = 2,
    LockStatus = "not_requested",
    Manager = "Monika",
    Name = "nandhu",
    Wfm_Manager = "Sabitha"
}
                        );
            modelBuilder.Entity<Skills>().HasData(

                new Skills
                {
                    Id = 1,
                    Name = "javascript"
                }
                    );


        }
        public DbSet<Users> Users
        {
            get;
            set;
        }
       public DbSet<Employees> Employees { get; set; }
       public DbSet<Skills> Skills { get; set; }
       public DbSet<SkillMap> SkillsMap { get; set; }
       public DbSet<SoftLock> SoftLock { get; set; }
    }
}
