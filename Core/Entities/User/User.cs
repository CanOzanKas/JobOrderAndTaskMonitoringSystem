using JobOrderAndTaskMonitoringSystem.Core.Enums;

namespace JobOrderAndTaskMonitoringSystem.Core.Entities.User {
    public class User {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname {  get; set; }
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public RoleEnum Role { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string DepartmentName { get; set; }
    }
}
