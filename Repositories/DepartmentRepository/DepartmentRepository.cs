using JobOrderAndTaskMonitoringSystem.Repositories.GenericRepository;
using JobOrderAndTaskMonitoringSystem.Core.Entities.DepartmentEntity;
using JobOrderAndTaskMonitoringSystem.Repositories.AppDbContext;

namespace JobOrderAndTaskMonitoringSystem.Repositories.DepartmentRepository {
    public class DepartmentRepository: GenericRepository<Department>, IDepartmentRepository {

        public DepartmentRepository(ApplicationDbContext dbContext): base(dbContext) { 
        }

    }
}
