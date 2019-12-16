using Autofac;
using System;

namespace DI.Class13._4th.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Config();

            using (var scope= container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
