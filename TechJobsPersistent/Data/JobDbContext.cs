using TechJobsPersistent.Models;
using Microsoft.EntityFrameworkCore;

namespace TechJobsPersistent.Data
{ //Part 1, #4 Read through the code that is currently in JobDbContext to get an idea for what the database will look like.
    public class JobDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<JobSkill> JobSkills { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobSkill>()
                .HasKey(j => new { j.JobId, j.SkillId });
        }
    }
}
