﻿using System.Web.Http.Dependencies;
using Microsoft.Practices.Unity;

namespace UDataCore.Dependency
{
    public class UnityDependencyResolver : UnityDependencyScope, IDependencyResolver
    {
        public UnityDependencyResolver(IUnityContainer container)
            : base(container)
        {

        }
        public IDependencyScope BeginScope()
        {
            var childContainer = Container.CreateChildContainer();

            return new UnityDependencyScope(childContainer);
        }

        
    }
}