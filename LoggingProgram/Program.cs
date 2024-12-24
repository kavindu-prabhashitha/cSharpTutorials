using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace LoggingProgram
{
    class Program

    {
        static void Main()

        {

            Log.Logger = new LoggerConfiguration()

                .WriteTo.Console()

                .WriteTo.File("log.txt")

                .CreateLogger();

            var serviceProvider = new ServiceCollection()

                //.AddLogging(configure => configure.AddSerilog())

                .AddSingleton<DataProcessingService>()

                .AddSingleton<IDataProcessor, UserInputProcessor>()

                //.AddSingleton<ILogger, CustomLogger>()

                .AddSingleton<ExceptionService>()

                .BuildServiceProvider();

            var logger = serviceProvider.GetService<ILogger<Program>>();

            var dataProcessingService = serviceProvider.GetService<DataProcessingService>();

            var exceptionService = serviceProvider.GetService<ExceptionService>();

            try

            {

                // Example of console and file logging

                dataProcessingService.ProcessAndDisplay("Hello, World!");

                // Example of custom logging

               // var customLogger = serviceProvider.GetService<ILogger>();
              
//customLogger.LogInformation("Custom log entry.");

                // Example of exception logging

                throw new InvalidOperationException("Simulated exception.");

            }

            catch (Exception ex)

            {

                exceptionService.HandleException(ex);

            }

            finally

            {

                Log.CloseAndFlush();

            }

        }
    }

}