using Autofac;
using DI.Class13.Third.Repository.Abstract;
using DI.Class13.Third.Repository.Concrete;
using System;
using System.Reflection;

namespace DI.Class13.Third
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

            var container = BuildContanier();
            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<Application>().Run();
            }
        }

        private static IContainer BuildContanier()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsSelf().AsImplementedInterfaces();

            builder.RegisterType<Application>();
            builder.RegisterType<InMemoryNumericStore>().As<INumericStore>();
            builder.RegisterType<Printer>().As<IPrinter>();
            builder.RegisterType<OptionService>().As<IOptionService>();

            return builder.Build();
        }
    }
}
