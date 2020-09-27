using System.Collections.Generic;

namespace TaskPlannerApi.Repositories.Entities
{
    /// <summary>
    /// The status entity --> Master table.
    /// </summary>
    public class Status : EntityBase
    {
        public Status()
        {
            TaskItems = new HashSet<TaskItem>();
        }

        /// <summary>
        /// Gets or sets the status name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tasks currently in this status.
        /// </summary>
        public ICollection<TaskItem> TaskItems { get; set; }
    }
}