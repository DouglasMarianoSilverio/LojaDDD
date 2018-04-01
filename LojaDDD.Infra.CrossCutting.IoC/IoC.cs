using LojaDDD.Infra.CrossCutting.IoC.Modules;
using Ninject;


namespace LojaDDD.Infra.CrossCutting.IoC
{
    public class IoC
    {
        public IKernel Kernel { get; private set; }

        public IoC()
        {
            Kernel = GetNinjectModules();
        }

        private IKernel GetNinjectModules()
        {
            return  new StandardKernel(
                new ApplicationNinjectModule(),
                new ServiceNinjectModule(),
                new RepositoryNinjectModule());
        }
    }
}
