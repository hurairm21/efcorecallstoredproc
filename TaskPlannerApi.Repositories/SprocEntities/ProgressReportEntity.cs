using System;

namespace TaskPlannerApi.Repositories.Entities
{
    public class ProgressReportEntity
    {
        public int TeamId { get; set; }

        public int UserId { get; set; }

        public int TotalTasks { get; set; }

        public int Todo { get; set; }

        public int InProgress { get; set; }

        public int Done { get; set; }
    } 
}
