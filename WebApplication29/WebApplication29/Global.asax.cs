using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Web.Optimization;
using WebApplication29.App_Start;
using AutoMapper;

namespace WebApplication29
{
    public class Global : HttpApplication
    {
        

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());

            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Bundleconfig.RegisterBundles(BundleTable.Bundles);
          
      
        
        
    }
        protected void Application_BeginRequest()
        {
            string[] allowedOrigin = new string[] { "http://localhost:2036" };
            var origin = HttpContext.Current.Request.Headers["Origin"];
            if (origin != null && allowedOrigin.Contains(origin))
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", origin);
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET,POST");
                //Need to add more later , will see when required
            }
        }
    }
}