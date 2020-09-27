namespace TaskPlannerApi.Repositories.Entities
{
    /// <summary>
    /// Note Entity.
    /// </summary>
    public class Note : EntityBase
    {
        /// <summary>
        /// Gets or sets the title of the note.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the detailed description of the note.
        /// </summary>
        public string Description { get; set; }

        public int TaskItemId { get; set; }

        /// <summary>
        /// Gets or sets the task this note is part of.
        /// </summary>
        public TaskItem TaskItem { get; set; }
    }
}
