using API.GymManagementSystem.Infrastructure.Data;
using API.GymManagementSystem.Infrastructure.Data.Entity;
using API.GymManagementSystem.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.GymManagementSystem.Services
{
   
    public class ActiveUsersServices:DBbase,IActiveUsersServices
    {
       
        public ActiveUsersServices(IConfiguration configuration):base(configuration)
        { 
        }
        public async Task<List<Active_Users>> ActiveUsers()
        {
            using (con = new SqlConnection(constr))
            {
                using (cmd = new SqlCommand("usp_getUserDetailsty", con))
                {
                   
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    con.Close();
                }
                
            }
            return null;
            //return ObjectMapper.Mapper.Map<List<Active_Users>>(result);
        }
    }
}
