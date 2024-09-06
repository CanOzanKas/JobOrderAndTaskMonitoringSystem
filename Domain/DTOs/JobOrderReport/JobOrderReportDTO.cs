using HwApp.Domain.DTOs.JobOrder;
using JobOrderAndTaskMonitoringSystem.Domain.DTOs.Task;

namespace JobOrderAndTaskMonitoringSystem.Domain.DTOs.JobOrderReport {
    public class JobOrderReportDTO {
        public int TotalOpenOrders { get; set; }

        public int TotalClosedOrders { get; set; }

        public int TotalCancelledOrders { get; set; }

        public List<JobOrderDTO> JobOrderDetails { get; set; }

        public List <TaskDTO> TasksRelatedToJob { get; set; }
    }
}
