using JobOrderAndTaskMonitoringSystem.Core.Enums;

namespace JobOrderAndTaskMonitoringSystem.Domain.DTOs.User
{
    public class UserDTO{
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Email { get; set; }

        public RoleEnum Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Department { get; set; }
    }
}
