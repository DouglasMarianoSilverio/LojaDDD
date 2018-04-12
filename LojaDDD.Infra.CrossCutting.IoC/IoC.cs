using LojaDDD.Infra.CrossCutting.IoC.Modules;
using SimpleInjector;
using SimpleInjector.Integration.Web;

//using Ninject;


namespace LojaDDD.Infra.CrossCutting.IoC
{
    public class IoC
    {
        //public IKernel Kernel { get; private set; }
        public Container Container { get; set; }    


        public IoC()
        {
            Container = new Container();
            Container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

        }

        //public  Container GetModules()
        //{
        //    ApplicationModule applicationModule = new ApplicationModule();
        //    ServiceModule serviceModule = new ServiceModule();
        //    RepositoryModule repositoryModule = new RepositoryModule();
        //    applicationModule.Load(Container);
        //    serviceModule.Load(Container);
        //    repositoryModule.Load(Container);
        //}

//        private IKernel GetNinjectModules()
//        {
//            return  new StandardKernel(
//                new ApplicationNinjectModule(),
//                new ServiceNinjectModule(),
//                new RepositoryNinjectModule());
//        }
    }
}
