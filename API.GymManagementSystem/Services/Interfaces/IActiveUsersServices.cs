using API.GymManagementSystem.Infrastructure.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.GymManagementSystem.Services.Interfaces
{
    public interface IActiveUsersServices
    {
        public Task<List<Active_Users>> ActiveUsers();
    }
}
