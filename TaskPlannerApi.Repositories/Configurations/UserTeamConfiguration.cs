using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskPlannerApi.Repositories.Entities;

namespace TaskPlannerApi.Repositories.Configurations
{
    public class UserTeamConfiguration : IEntityTypeConfiguration<UserTeam>
    {
        public void Configure(EntityTypeBuilder<UserTeam> builder)
        {
            builder.ToTable("UserTeam");
            builder.HasOne(ut => ut.User).WithMany(user => user.UserTeams).HasForeignKey(ut => ut.UserId);
            builder.HasOne(ut => ut.Team).WithMany(team => team.UserTeams).HasForeignKey(ut => ut.TeamId);

            builder.HasKey(ut => new { ut.UserId, ut.TeamId });
        }
    }
}
