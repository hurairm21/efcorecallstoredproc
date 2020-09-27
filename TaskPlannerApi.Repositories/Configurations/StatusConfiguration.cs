using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories.Configurations
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            builder.Property(status => status.Name).IsRequired().HasMaxLength(64);

            builder.HasKey(status => status.Id);
            builder.Property(status => status.Id).ValueGeneratedOnAdd();

            builder.HasMany(status => status.TaskItems).WithOne(task => task.Status).HasForeignKey(task => task.StatusId);
        }
    }
}
