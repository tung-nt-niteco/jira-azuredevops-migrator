using System;
using Migration.Common.Log;

namespace JiraExport
{
    static class Program
    {
        static void Main(string[] args)
        {
            VersionInfo.PrintInfoMessage("Jira Exporter");

            try
            {
                //Tung Test
                //args = new string[]
                //{
                //    "-u", "tung.nt",
                //    "-p", "password of Tung",
                //    "--url", "https://jira.domain/",
                //    "--config", "D:\\2az\\MigratorConfigGenerator\\config-agile-AH-TungTest.json",
                //    "--force"
                //};

                var cmd = new JiraCommandLine(args);
                cmd.Run();

                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Application stopped due to an unexpected exception", LogLevel.Critical);
            }
        }
    }
}
