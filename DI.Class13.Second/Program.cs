using Autofac;
using System;
using System.Reflection;

namespace DI.Class13.Second
{
    class Program
    {
        static void Main(string[] args)
        {
            //var printer = new Printer();
            //var numericStore = new InMemoryNumericStore();
            //var optionService = new OptionService(numericStore, printer);
            //var application = new Application(optionService, printer);
            //application.Run();

            //with Autofac and DI
            var container = BuildContainer();
            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<Application>().Run();
            }
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces();
            return builder.Build();
        }
    }
}
