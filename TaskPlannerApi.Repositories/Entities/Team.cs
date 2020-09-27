using System.Collections.Generic;

namespace TaskPlannerApi.Repositories.Entities
{
    /// <summary>
    /// The team entity --> master entity.
    /// </summary>
    public class Team : EntityBase
    {
        public Team()
        {
            UserTeams = new HashSet<UserTeam>();
        }


        /// <summary>
        /// Gets or sets the name of the team.
        /// </summary>
        public string Name { get; set; }

        public ICollection<UserTeam> UserTeams { get; set; }
    }
}
