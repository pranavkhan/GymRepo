using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.GymManagementSystem.Infrastructure.Data
{
    public class DBbase
    {
        public static string constr = "";
        private readonly IConfiguration Configuration;
        public SqlConnection con;
        public SqlCommand cmd;

        public DBbase(IConfiguration configuration)
        {
            Configuration = configuration;
            constr = Configuration["ConnectionStrings:CnStrGymApp"].ToString();
        }

    }
}
