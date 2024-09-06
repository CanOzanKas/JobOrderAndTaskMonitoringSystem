using JobOrderAndTaskMonitoringSystem.Core.Enums;

namespace HwApp.Domain.DTOs.JobOrder {
    public class JobOrderDTO {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public PriorityEnum Priority { get; set; }

        public DateTime EstimatedCompletionDate { get; set; }

        public StatusEnum Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
