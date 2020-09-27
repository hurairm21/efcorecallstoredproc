using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(user => user.FirstName).IsRequired().HasMaxLength(128);
            builder.Property(user => user.LastName).IsRequired(false).HasMaxLength(128);
            builder.Property(user => user.Username).IsRequired().HasMaxLength(64);
            builder.Property(user => user.Email).IsRequired().HasMaxLength(256);

            builder.HasKey(user => user.Id);
            builder.Property(user => user.Id).ValueGeneratedOnAdd();

            builder.HasMany(user => user.TaskItems).WithOne(task => task.User);
        }
    }
}
