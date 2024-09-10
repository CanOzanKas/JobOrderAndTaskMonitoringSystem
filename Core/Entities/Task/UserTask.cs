using JobOrderAndTaskMonitoringSystem.Core.Enums;

namespace JobOrderAndTaskMonitoringSystem.Core.Entities.UserTask {
    public class UserTask {
        public int Id { get; set; }
        public int JobOrderId { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int AssignedTo { get; set; }

        public DateTime DueDate { get; set; }

        public StatusEnum Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
