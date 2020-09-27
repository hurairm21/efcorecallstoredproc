using System.Collections.Generic;

namespace TaskPlannerApi.Repositories.Entities
{
    /// <summary>
    /// Task entity.
    /// </summary>
    public class TaskItem : EntityBase
    {
        public TaskItem()
        {
            Notes = new HashSet<Note>();
        }

        /// <summary>
        /// Gets or sets the name of the task.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the task.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the status id of the task.
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// Gets or sets the status of the task.
        /// </summary>
        public Status Status { get; set; }

        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the person this task is assigned to.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the Notes made for the task.
        /// </summary>
        public ICollection<Note> Notes { get; set; }
    }
}
