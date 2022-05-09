using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.GymManagementSystem.Models
{
    public class CommonResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public String Message { get; set; }
        public T Result { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
