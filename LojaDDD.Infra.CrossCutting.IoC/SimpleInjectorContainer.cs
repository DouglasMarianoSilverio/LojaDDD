using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LojaDDD.Infra.CrossCutting.IoC.Modules;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace LojaDDD.Infra.CrossCutting.IoC
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices( Assembly assembly)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle =  new WebRequestLifestyle();
            ApplicationModule applicationModule = new ApplicationModule();
            ServiceModule serviceModule = new ServiceModule();
            RepositoryModule repositoryModule = new RepositoryModule();
            applicationModule.Load(container);
            serviceModule.Load(container);
            repositoryModule.Load(container);
            container.RegisterMvcControllers(assembly);
            container.Verify();
            return container;

        }
    }
}
