using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Core;

namespace UmbRoutingTest.Events
{
    public class AppEventHandler : ApplicationEventHandler
    {

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
        }
    }
}