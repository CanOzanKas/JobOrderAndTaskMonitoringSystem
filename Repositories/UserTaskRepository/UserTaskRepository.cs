using JobOrderAndTaskMonitoringSystem.Repositories.GenericRepository;
using JobOrderAndTaskMonitoringSystem.Core.Entities.UserTask;
using JobOrderAndTaskMonitoringSystem.Core.Enums;
using JobOrderAndTaskMonitoringSystem.Core.Entities.JobOrder;
using JobOrderAndTaskMonitoringSystem.Repositories.AppDbContext;


namespace JobOrderAndTaskMonitoringSystem.Repositories.TaskRepository {
    public class UserTaskRepository:GenericRepository<UserTask>,IUserTaskRepository {

        public UserTaskRepository(ApplicationDbContext dbContext):base(dbContext) { }

        public IEnumerable<UserTask> GetAllTasksByDepartment(string Department) {
            _dbContext
        }

        public IEnumerable<UserTask> GetAllTasksByStatus(StatusEnum Status) {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTask> GetAllTasksByUserId(int UserId) {
            throw new NotImplementedException();
        }

        public JobOrder GetRelatedJobOrder(UserTask task) {
            throw new NotImplementedException();
        }
    }
}
