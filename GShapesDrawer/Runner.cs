using Autofac;
using GShapesDrawer.Services;

namespace GShapesDrawer
{
    static class Runner
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();
            new GShapesDrawerProgram(container).Run();
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<OutputService>().As<IOutputService>();
            builder.RegisterType<FileOutput>().As<IFileOutput>();
            builder.RegisterType<ConsoleOutput>().As<IConsoleOutput>();
            
            return builder.Build();
        }
    }
}