using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using Umbraco.Web.WebApi;

namespace UmbRoutingTest.ApiControllers
{
    [RoutePrefix("api/value")]
    public class ValueController : UmbracoApiController
    {

        [Route(Name = "GetValues")]
        public FormattedContentResult<string> Get()
        {
            return base.Content(HttpStatusCode.OK, "Content", new JsonMediaTypeFormatter());
        }
    }
}