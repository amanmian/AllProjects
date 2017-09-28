using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using AutoMapper;
using _09.App_Start;
using System.Web.Optimization;

namespace _09
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //register Mapping profile from appstart
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            BundleConfig1.RegisterBundles(BundleTable.Bundles);
        }
    }
}