using System.Collections.Generic;

namespace TaskPlannerApi.Repositories.Entities
{
    /// <summary>
    /// This entity is not for authentication, this is an entity. --> Master table.
    /// </summary>
    public class User : EntityBase
    {
        public User()
        {
            UserTeams = new HashSet<UserTeam>();
            TaskItems = new HashSet<TaskItem>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the tasks assigned to this user.
        /// </summary>
        public ICollection<TaskItem> TaskItems { get; set; }

        public ICollection<UserTeam> UserTeams { get; set; }
    }
}