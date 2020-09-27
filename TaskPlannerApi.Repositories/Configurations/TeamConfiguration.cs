using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team");
            builder.HasKey(team => team.Id);
            builder.Property(team => team.Id).ValueGeneratedOnAdd();

            builder.Property(team => team.Name).IsRequired().HasMaxLength(128);
        }
    }
}
