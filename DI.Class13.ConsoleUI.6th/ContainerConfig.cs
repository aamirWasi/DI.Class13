using Autofac;
using DemoLibraryThird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DI.Class13.ConsoleUI._6th
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<OptionService>().As<IOptionService>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibraryThird)))
                .Where(t => t.Namespace.Contains("Utilities")).As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
