using JobOrderAndTaskMonitoringSystem.Repositories.GenericRepository;
using JobOrderAndTaskMonitoringSystem.Core.Entities.JobOrder;
using JobOrderAndTaskMonitoringSystem.Repository.AppDbContext;

namespace JobOrderAndTaskMonitoringSystem.Repositories.JobOrderRepository {
    public class JobOrderRepository:GenericRepository<JobOrder> {
        public JobOrderRepository(ApplicationDbContext dbContext): base(dbContext) { }
    }
}
