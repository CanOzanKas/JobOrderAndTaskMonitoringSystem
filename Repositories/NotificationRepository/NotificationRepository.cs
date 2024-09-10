using JobOrderAndTaskMonitoringSystem.Core.Entities.Notification;
using JobOrderAndTaskMonitoringSystem.Repositories.GenericRepository;
using JobOrderAndTaskMonitoringSystem.Repository.AppDbContext;
namespace JobOrderAndTaskMonitoringSystem.Repositories.NotificationRepository {
    public class NotificationRepository:GenericRepository<Notification> {

        public NotificationRepository(ApplicationDbContext context) : base(context) { } 
    }
}
