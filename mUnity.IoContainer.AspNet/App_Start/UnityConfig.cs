using mUnity.IoContainer.AspNet.Interfaces;
using mUnity.IoContainer.AspNet.Repository;
using System;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace mUnity.IoContainer.AspNet
{

    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductRepository, ProductRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

    }
}