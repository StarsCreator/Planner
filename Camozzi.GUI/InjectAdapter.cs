﻿using Camozzi.Presentation.Injection;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.GUI
{
    public class InjectAdapter: IContainer
    {
        private readonly ServiceContainer _container = new ServiceContainer();

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _container.Register<TService, TImplementation>();
        }

        public void RegisterSingletone<TService, TImplementation>() where TImplementation : TService
        {
            _container.Register<TService, TImplementation>(new PerContainerLifetime());
        }

        public void Register<TService>()
        {
            _container.Register<TService>();
        }

        public void RegisterInstance<T>(T instance)
        {
            _container.RegisterInstance(instance);
        }

        public void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory)
        {
            _container.Register(serviceFactory => factory);
        }

        public TService Resolve<TService>()
        {
            return _container.GetInstance<TService>();
        }

        public bool IsRegistered<TService>()
        {
            return _container.CanGetInstance(typeof(TService), string.Empty);
        }
    }
}
