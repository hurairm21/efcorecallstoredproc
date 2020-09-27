using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories.Configurations
{
    public class TaskItemConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {
            builder.ToTable("TaskItem");
            builder.Property(task => task.Name).IsRequired().HasMaxLength(128);
            builder.Property(task => task.Description).IsRequired(false);
            builder.Property(task => task.StatusId).IsRequired();

            builder.HasKey(task => task.Id);
            builder.Property(task => task.Id).ValueGeneratedOnAdd();

            builder.HasOne(task => task.Status).WithMany(status => status.TaskItems).HasForeignKey(task => task.StatusId);
            builder.HasMany(task => task.Notes).WithOne(note => note.TaskItem).HasForeignKey(note => note.TaskItemId);
            builder.HasOne(task => task.User).WithMany(user => user.TaskItems).HasForeignKey(task => task.UserId);
        }
    }
}
