using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EventFlowConsoleApp
{
    internal class Program
    {
        private static IConfiguration Configuration { get; set; }
        private static IContainer Container { get; set; }

        private static async Task Main(string[] args)
        {
            CancellationToken cancellationToken;
            RegisterServices();
            var examService = Container.Resolve<ExamService>();
            var studentId = Guid.NewGuid();
            var result = await examService.AssignExamAsync("ABC", studentId, cancellationToken);
            Console.WriteLine($"Results: {result}");
        }

        private static void RegisterServices()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("local.settings.json")
                .AddEnvironmentVariables()
                .Build();


            var loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            ILogger logger = loggerFactory.CreateLogger<Program>();

            var mongoDbUri = Configuration.GetValue<string>("mongoDbUri");
            var mongoDbName = Configuration.GetValue<string>("mongoDbName");

            var containerBuilder = new ContainerBuilder().AddEventFlow(mongoDbUri, mongoDbName);

            containerBuilder.RegisterType<ExamService>().AsSelf().As<IExamService>();
            containerBuilder.RegisterInstance(logger);

            Container = containerBuilder.Build();
        }
    }
}
