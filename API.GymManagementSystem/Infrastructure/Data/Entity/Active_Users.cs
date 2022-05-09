using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.GymManagementSystem.Infrastructure.Data.Entity
{
    public class Active_Users
    {
        public string Auditid { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string ActiveStatus { get; set; }
        public DateTime LogInTime { get; set; }
        public DateTime LogoutTime { get; set; }
        public string Action { get; set; }
        public string Browser { get; set; }
        public string IPAddress { get; set; }

    }
}
