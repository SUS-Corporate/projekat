using PR46_2019_Web_projekat.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PR46_2019_Web_projekat.Controllers
{
    public class SessionController : ApiController
    {
        [HttpGet]
        [Route("api/Session/getSession")]
        public IHttpActionResult GetSessionData()
        {
            return Ok(1);
        }
    }
}
