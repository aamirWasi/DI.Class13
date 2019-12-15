using Autofac;
using System;
using System.Reflection;

namespace DI.Class13.First
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<Application>().Run();
            }
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<Application>();
            //builder.RegisterType<OptionsService>().As<IOptionsService>();
            //builder.RegisterType<InMemorynumericStore>().As<INumericStore>();
            //builder.RegisterType<Printer>().As<IPrinter>();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
