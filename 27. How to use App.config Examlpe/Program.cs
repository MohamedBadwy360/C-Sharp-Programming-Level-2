using System;
using System.Configuration;

// App config 
/*

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<appSettings>
		<add key="ConnectionString" value="Server = .; Database = EmployeesDB; User Id = sa; Password = sa123456"/>
		<add key="LogLevel" value="Debug"/>
	</appSettings>
	<connectionStrings>
		<add name="MyDBConnection" connectionString="Server = .; Database = EmployeesDB; User Id = sa; Password = sa123456"/>
	</connectionStrings>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
    </startup>
</configuration>

*/

namespace _27.How_to_use_App.config_Examlpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            string logLevel = ConfigurationManager.AppSettings["LogLevel"];

            string MyDBConnection = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            Console.WriteLine($"ConnectionString : {ConnectionString}");
            Console.WriteLine($"logLevel : {logLevel}");
            Console.WriteLine($"MyDBConnection : {MyDBConnection}");
        }
    }
}
