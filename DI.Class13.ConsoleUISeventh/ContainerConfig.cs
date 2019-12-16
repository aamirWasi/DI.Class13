using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using DemoLibrarySeventh;

namespace DI.Class13.ConsoleUISeventh
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<OptionService>
        } 
    }
}
