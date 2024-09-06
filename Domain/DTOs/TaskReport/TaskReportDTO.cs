using JobOrderAndTaskMonitoringSystem.Domain.DTOs.Task;

namespace JobOrderAndTaskMonitoringSystem.Domain.DTOs.TaskReport {
    public class TaskReportDTO {
        public int TotalTasks { get; set; }

        public int CompletedTasks { get; set; }

        public int PendingTasks { get; set; }

        public List<TaskDTO> TaskDetails { get; set; }
    }
}
