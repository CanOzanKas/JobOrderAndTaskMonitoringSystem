using JobOrderAndTaskMonitoringSystem.Repositories.GenericRepository;
using JobOrderAndTaskMonitoringSystem.Core.Entities.User;
using JobOrderAndTaskMonitoringSystem.Repository.AppDbContext;

namespace JobOrderAndTaskMonitoringSystem.Repositories.UserRepository {
    public class UserRepository:GenericRepository<User>, IUserRepository {

        public UserRepository(ApplicationDbContext context) : base(context) { } 
    }
}
