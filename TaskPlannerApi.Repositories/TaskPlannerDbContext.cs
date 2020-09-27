using Microsoft.EntityFrameworkCore;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories
{
    public class TaskPlannerDbContext : DbContext
    {
        public TaskPlannerDbContext(DbContextOptions<TaskPlannerDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<TaskItem> TaskItems { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<UserTeam> UserTeams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskPlannerDbContext).Assembly);
        }
    }
}
