namespace JobOrderAndTaskMonitoringSystem.Core.Entities.Notification {
    public class Notification {
        public int Id { get; set; }
        public string Message { get; set; }

        public int UserId { get; set; }

        public int TaskId { get; set; }
    }
}
