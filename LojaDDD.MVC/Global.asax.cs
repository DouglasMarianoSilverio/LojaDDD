using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LojaDDD.Infra.CrossCutting.IoC;
using LojaDDD.MVC.AutoMapper;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;


namespace LojaDDD.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Container container = SimpleInjectorContainer.RegisterServices(Assembly.GetExecutingAssembly());
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container)) ;
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
        }

        
    }
}
