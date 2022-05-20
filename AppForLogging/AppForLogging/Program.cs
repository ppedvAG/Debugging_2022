using Serilog;
using Serilog.Core;
using Serilog.Formatting.Compact;
using Serilog.Formatting.Json;

namespace AppForLogging
{
    internal static class Program
    {

        public static Logger Logger;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logger = new LoggerConfiguration()
               .Enrich.WithMachineName()
               .Enrich.WithEnvironmentUserName()
               .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
               .WriteTo.File(new CompactJsonFormatter(), "log.json", rollingInterval: RollingInterval.Day)
               .WriteTo.Seq("http://localhost:5341")
               .CreateLogger();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}