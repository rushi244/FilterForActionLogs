using FilterForActionLogs.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FilterForActionLogs.Controllers
{
    [ActionLogs]
    public class EmployeeController : ApiController
    {
        public IHttpActionResult Get()
        {
            var result = "Get method without paramenter";

            if(result!=null)
            {
                return Ok(result);
            }
            return NotFound();
        }
        public IHttpActionResult GetById(int id)
        {
            var result = "Get method with paramenter";

            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

    }
}
