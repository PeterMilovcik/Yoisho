using System;
using Autofac;
using Yoisho.Services.Dialog;
using Yoisho.Services.Navigation;
using Yoisho.Services.Preference;
using Yoisho.Services.Repository;
using Yoisho.ViewModels;

namespace Yoisho.Bootstrap
{
    public class AppContainer
    {
        private static IContainer container;

        public AppContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<DialogService>().As<IDialogService>().SingleInstance();
            builder.RegisterType<RepositoryService>().As<IRepositoryService>().SingleInstance();
            builder.RegisterType<PreferenceService>().As<IPreferenceService>().SingleInstance();

            builder.RegisterType<MainViewModel>().SingleInstance();

            container = builder.Build();
        }

        public T Resolve<T>() => container.Resolve<T>();

        public object Resolve(Type type) => container.Resolve(type);
    }
}
