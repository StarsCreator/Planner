using System;
using System.Linq.Expressions;

namespace Camozzi.Presentation.Injection
{
    public interface IContainer
    {
        void Register<TService, TImplementation>() where TImplementation : TService;
        void Register<TService>();
        void RegisterSingletone<TService, TImplementation>() where TImplementation : TService;
        void RegisterInstance<T>(T instance);
        TService Resolve<TService>();
        bool IsRegistered<TService>();
        void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory);
    }
}
