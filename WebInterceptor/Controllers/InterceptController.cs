using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using WebInterceptor.Models;

namespace WebInterceptor.Controllers
{
    
    public class InterceptController : ApiController
    {
        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public HttpResponseMessage Post([FromBody] InterceptorContext value)
        {
            if (Request.Headers.Contains("Authorization"))
            {
                return Request.CreateResponse<String>(HttpStatusCode.OK, String.Join(",", Request.Headers.GetValues("Authorization")));
                // if the request header contains the auth token then strip it out.
            }
            return Request.CreateResponse<String>(HttpStatusCode.OK, "NO AUTHORIZATION HEADER");
        }
    }
}
