using JobOrderAndTaskMonitoringSystem.Core.Entities.Notification;
using JobOrderAndTaskMonitoringSystem.Core.Entities.User;
using JobOrderAndTaskMonitoringSystem.Core.Entities.JobOrder;
using Microsoft.EntityFrameworkCore;
using JobOrderAndTaskMonitoringSystem.Core.Entities.DepartmentEntity;

namespace JobOrderAndTaskMonitoringSystem.Repositories.AppDbContext {
    public class ApplicationDbContext:DbContext {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<JobOrder> JobOrders { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
