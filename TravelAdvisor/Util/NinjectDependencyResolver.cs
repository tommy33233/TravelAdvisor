using System;
using System.Collections.Generic;
using System.Web.Mvc;

using BLL.Interfaces;
using BLL.Services;
using Ninject;

namespace TravelAdvisor.Util
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public object GetServices(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IService>().To<MainService>();
        }

        IEnumerable<object> IDependencyResolver.GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}