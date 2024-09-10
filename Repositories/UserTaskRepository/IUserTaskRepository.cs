using JobOrderAndTaskMonitoringSystem.Core.Enums;
using JobOrderAndTaskMonitoringSystem.Core.Entities.JobOrder;
using JobOrderAndTaskMonitoringSystem.Core.Entities.UserTask;

namespace JobOrderAndTaskMonitoringSystem.Repositories.TaskRepository {
    public interface IUserTaskRepository {
        IEnumerable<UserTask> GetAllTasksByDepartment(string Department);

        IEnumerable<UserTask> GetAllTasksByStatus(StatusEnum Status);

        IEnumerable<UserTask> GetAllTasksByUserId(int UserId);

        JobOrder GetRelatedJobOrder(UserTask task);
    }
}
