using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApi.Jwt.Filters;

namespace WebApi.Jwt.Controllers
{
    [JwtAuthentication]
    public class ValueController : ApiController
    {
        public string Get()
        {
            var username = HttpContext.Current.User.Identity.Name;

            return username;
        }

        [Authorize(Roles = "Admin")]
        public string Get(int id)
        {
            return $"{id}\t{HttpContext.Current.User.Identity.Name}";
        }
    }
}
